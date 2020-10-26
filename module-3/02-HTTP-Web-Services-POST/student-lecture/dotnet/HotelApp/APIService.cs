using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_POST_PUT_DELETE_lecture
{
    class APIService
    {
        private readonly string API_URL = "";
        private readonly RestClient client = new RestClient();

        public APIService(string api_url)
        {
            if (api_url.Contains("REPLACEME"))
            {
                throw new ArgumentOutOfRangeException(nameof(api_url), "You didn't set your laptop ID in UserInterface.cs");
            }
            API_URL = api_url;
        }

        public List<Hotel> GetHotels()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetReservations(int hotelId = 0)
        {
            throw new NotImplementedException();
        }

        public Reservation GetReservation(int reservationId)
        {
            throw new NotImplementedException();
        }

        public Reservation AddReservation(Reservation newReservation)
        {
            throw new NotImplementedException();
        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            throw new NotImplementedException();
        }

        public void DeleteReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }
}
