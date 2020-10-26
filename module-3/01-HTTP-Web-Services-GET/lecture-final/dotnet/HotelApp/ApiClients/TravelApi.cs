using HTTP_Web_Services_GET_lecture.Data;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTTP_Web_Services_GET_lecture.ApiClients
{
    public class TravelApi
    {
        public string GetRecommendedDestination()
        {
            // TODO: Call out to http://swapi.dev/api/planets/5/
            RestClient client = new RestClient();
            RestRequest request = new RestRequest("https://swapi.dev/api/planets/2/");
            IRestResponse<Planet> result = client.Get<Planet>(request);

            Planet destination = result.Data;

            return destination.Name;
        }
    }
}
