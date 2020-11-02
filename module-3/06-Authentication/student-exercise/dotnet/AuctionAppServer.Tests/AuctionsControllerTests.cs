using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AuctionApp.Models;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AuctionApp.Controllers;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Net.Http.Headers;
using System.Text;

namespace AuctionApp.Tests
{
    [TestClass]
    public class AuctionsControllerTests
    {
        protected HttpClient _client;

        [TestInitialize]
        public void Setup()
        {
            var builder = new WebHostBuilder()
                .UseStartup<AuctionApp.Startup>()
                .UseConfiguration(new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build());
            var server = new TestServer(builder);
            _client = server.CreateClient();
        }

        [TestMethod]
        public async Task Step4_AllMethods_ExpectUnauthorized()
        {
            Auction input = new Auction() { Id = null, Title = "Dragon Plush", Description = "Not a real dragon", User = "Bernice", CurrentBid = 19.50 };

            var responseGetAuction1 = await _client.GetAsync("auctions/1");
            var responsePostAuction = await _client.PostAsync("auctions", BuildJsonContent(input));
            var responsePutAuction = await _client.PutAsync("auctions/1", BuildJsonContent(input));
            var responseDeleteAuction = await _client.DeleteAsync("auctions/1");

            Assert.AreEqual(System.Net.HttpStatusCode.Unauthorized, responseGetAuction1.StatusCode);
            Assert.AreEqual(System.Net.HttpStatusCode.Unauthorized, responsePostAuction.StatusCode);
            Assert.AreEqual(System.Net.HttpStatusCode.Unauthorized, responsePutAuction.StatusCode);
            Assert.AreEqual(System.Net.HttpStatusCode.Unauthorized, responseDeleteAuction.StatusCode);

            var attrs = System.Attribute.GetCustomAttributes(typeof(AuctionsController)).ToList();
            Assert.IsTrue(attrs.Any(a => a is AuthorizeAttribute), "Authorize attribute missing from controller class.");
        }

        [TestMethod]
        public async Task Step4_GetAuctions_ExpectOk()
        {
            var responseGetAuctions = await _client.GetAsync("auctions");
            var responseGetAuction1 = await _client.GetAsync("auctions/1");

            Assert.AreEqual(System.Net.HttpStatusCode.OK, responseGetAuctions.StatusCode);
            Assert.AreEqual(System.Net.HttpStatusCode.Unauthorized, responseGetAuction1.StatusCode);
        }

        [TestMethod]
        public async Task Step5_CreateMethod()
        {
            string json = "{\"Title\": \"Dragon Plush\", \"Description\": \"Not a real dragon\", \"User\": \"Bernice\", \"CurrentBid\": 19.50}";
            var inputContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            string viewerToken = await GetViewerLogin();
            string creatorToken = await GetCreatorLogin();
            string adminToken = await GetAdminLogin();

            var requestViewer = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions"), Method = HttpMethod.Post, Content = inputContent };
            requestViewer.Headers.Authorization = new AuthenticationHeaderValue("Bearer", viewerToken);
            var responseViewer = await _client.SendAsync(requestViewer);

            var requestCreator = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions"), Method = HttpMethod.Post, Content = inputContent };
            requestCreator.Headers.Authorization = new AuthenticationHeaderValue("Bearer", creatorToken);
            var responseCreator = await _client.SendAsync(requestCreator);

            var requestAdmin = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions"), Method = HttpMethod.Post, Content = inputContent };
            requestAdmin.Headers.Authorization = new AuthenticationHeaderValue("Bearer", adminToken);
            var responseAdmin = await _client.SendAsync(requestAdmin);

            Assert.AreEqual(System.Net.HttpStatusCode.Forbidden, responseViewer.StatusCode);
            Assert.IsTrue(responseCreator.IsSuccessStatusCode);
            Assert.IsTrue(responseAdmin.IsSuccessStatusCode);
        }

        [TestMethod]
        public async Task Step5_UpdateMethod()
        {
            string json = "{\"Id\": 2, \"Title\": \"Dragon Plush\", \"Description\": \"Not a real dragon\", \"User\": \"Bernice\", \"CurrentBid\": 19.50}";
            var inputContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            string viewerToken = await GetViewerLogin();
            string creatorToken = await GetCreatorLogin();
            string adminToken = await GetAdminLogin();

            var requestViewer = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions/2"), Method = HttpMethod.Put, Content = inputContent };
            requestViewer.Headers.Authorization = new AuthenticationHeaderValue("Bearer", viewerToken);
            var responseViewer = await _client.SendAsync(requestViewer);

            var requestCreator = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions/3"), Method = HttpMethod.Put, Content = inputContent };
            requestCreator.Headers.Authorization = new AuthenticationHeaderValue("Bearer", creatorToken);
            var responseCreator = await _client.SendAsync(requestCreator);

            var requestAdmin = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions/4"), Method = HttpMethod.Put, Content = inputContent };
            requestAdmin.Headers.Authorization = new AuthenticationHeaderValue("Bearer", adminToken);
            var responseAdmin = await _client.SendAsync(requestAdmin);

            Assert.AreEqual(System.Net.HttpStatusCode.Forbidden, responseViewer.StatusCode);
            Assert.IsTrue(responseCreator.IsSuccessStatusCode);
            Assert.IsTrue(responseAdmin.IsSuccessStatusCode);
        }

        [TestMethod]
        public async Task Step5_DeleteMethod()
        {
            string viewerToken = await GetViewerLogin();
            string creatorToken = await GetCreatorLogin();
            string adminToken = await GetAdminLogin();

            var requestViewer = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions/1"), Method = HttpMethod.Delete };
            requestViewer.Headers.Authorization = new AuthenticationHeaderValue("Bearer", viewerToken);
            var responseViewer = await _client.SendAsync(requestViewer);

            var requestCreator = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions/1"), Method = HttpMethod.Delete };
            requestCreator.Headers.Authorization = new AuthenticationHeaderValue("Bearer", creatorToken);
            var responseCreator = await _client.SendAsync(requestCreator);

            var requestAdmin = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions/1"), Method = HttpMethod.Delete };
            requestAdmin.Headers.Authorization = new AuthenticationHeaderValue("Bearer", adminToken);
            var responseAdmin = await _client.SendAsync(requestAdmin);

            Assert.AreEqual(System.Net.HttpStatusCode.Forbidden, responseViewer.StatusCode);
            Assert.AreEqual(System.Net.HttpStatusCode.Forbidden, responseCreator.StatusCode);
            Assert.IsTrue(responseAdmin.IsSuccessStatusCode);
        }

        [TestMethod]
        public async Task Step6_WhoAmI()
        {
            string viewerToken = await GetViewerLogin();
            string creatorToken = await GetCreatorLogin();
            string adminToken = await GetAdminLogin();

            var requestViewer = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions/whoami"), Method = HttpMethod.Get };
            requestViewer.Headers.Authorization = new AuthenticationHeaderValue("Bearer", viewerToken);
            var responseViewer = await _client.SendAsync(requestViewer);
            string responseViewerContent = await responseViewer.Content.ReadAsStringAsync();

            var requestCreator = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions/whoami"), Method = HttpMethod.Get };
            requestCreator.Headers.Authorization = new AuthenticationHeaderValue("Bearer", creatorToken);
            var responseCreator = await _client.SendAsync(requestCreator);
            string responseCreatorContent = await responseCreator.Content.ReadAsStringAsync();

            var requestAdmin = new HttpRequestMessage() { RequestUri = new Uri(_client.BaseAddress + "auctions/whoami"), Method = HttpMethod.Get };
            requestAdmin.Headers.Authorization = new AuthenticationHeaderValue("Bearer", adminToken);
            var responseAdmin = await _client.SendAsync(requestAdmin);
            string responseAdminContent = await responseAdmin.Content.ReadAsStringAsync();

            Assert.AreEqual("test", responseViewerContent);
            Assert.AreEqual("johnny", responseCreatorContent);
            Assert.AreEqual("admin", responseAdminContent);
        }


        private async Task<string> GetViewerLogin()
        {
            var viewerResponse = await _client.PostAsync("login", BuildJsonContent(new { username = "test", password = "test" }));
            string viewerResponseContent = await viewerResponse.Content.ReadAsStringAsync();
            User viewer = JsonConvert.DeserializeObject<User>(viewerResponseContent);
            return viewer.Token;
        }
        private async Task<string> GetCreatorLogin()
        {
            var creatorResponse = await _client.PostAsync("login", BuildJsonContent(new { username = "johnny", password = "test" }));
            string creatorResponseContent = await creatorResponse.Content.ReadAsStringAsync();
            User creator = JsonConvert.DeserializeObject<User>(creatorResponseContent);
            return creator.Token;
        }
        private async Task<string> GetAdminLogin()
        {
            var adminResponse = await _client.PostAsync("login", BuildJsonContent(new { username = "admin", password = "admin" }));
            string adminResponseContent = await adminResponse.Content.ReadAsStringAsync();
            User admin = JsonConvert.DeserializeObject<User>(adminResponseContent);
            return admin.Token;
        }

        private static StringContent BuildJsonContent(object input)
        {
            return new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
        }
    }
}
