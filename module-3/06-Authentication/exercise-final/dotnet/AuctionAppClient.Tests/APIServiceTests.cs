using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentAssertions;
using Moq;
using RestSharp;
using System.Net;
using System.Text;

namespace AuctionApp.Tests
{
    [TestClass]
    public class APIServiceTests
    {
        [TestMethod]
        public void Step2_LoginMethod()
        {
            // Arrange
            API_User expected = new API_User { Username = "test", Token = "abcdefgh123456789", Message = null };

            Mock<IRestClient> restClient = new Mock<IRestClient>();
            restClient.Setup(x => x.Execute<API_User>(It.IsAny<IRestRequest>(), Method.POST))
                .Returns(new RestResponse<API_User>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = expected,
                    ResponseStatus = ResponseStatus.Completed
                });
            APIService apiService = new APIService(restClient.Object);

            // Act
            API_User actual = apiService.Login("test", "test");

            // Assert
            expected.Should().BeEquivalentTo(actual); // Uses FluentAssertions
        }

        [TestMethod]
        public void Step3_UnauthorizedResponse()
        {
            // Arrange
            var response = new RestResponse<Auction>
            {
                StatusCode = HttpStatusCode.Unauthorized,
                ResponseStatus = ResponseStatus.Completed
            };
            APIService apiService = new APIService();

            // Act
            string actual = apiService.ProcessErrorResponse(response);

            Assert.AreEqual(apiService.UNAUTHORIZED_MSG, actual);
        }

        [TestMethod]
        public void Step3_ForbiddenResponse()
        {
            // Arrange
            var response = new RestResponse<Auction>
            {
                StatusCode = HttpStatusCode.Forbidden,
                ResponseStatus = ResponseStatus.Completed
            };
            APIService apiService = new APIService();

            // Act
            string actual = apiService.ProcessErrorResponse(response);

            Assert.AreEqual(apiService.FORBIDDEN_MSG, actual);
        }

        [TestMethod]
        public void Step3_Other4xxResponse()
        {
            // Arrange
            var response = new RestResponse<Auction>
            {
                StatusCode = HttpStatusCode.BadRequest,
                ResponseStatus = ResponseStatus.Completed
            };
            APIService apiService = new APIService();

            // Act
            string actual = apiService.ProcessErrorResponse(response);

            Assert.AreEqual(apiService.OTHER_4XX_MSG + "400", actual);
        }
    }
}
