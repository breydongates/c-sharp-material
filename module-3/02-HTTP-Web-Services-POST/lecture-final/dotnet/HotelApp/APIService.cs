using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_POST_PUT_DELETE_lecture
{
    public class APIService
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
            RestRequest request = new RestRequest(this.API_URL + "hotels");

            IRestResponse<List<Hotel>> response = this.client.Get<List<Hotel>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not fetch a list of hotels");
                return new List<Hotel>();
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Encountered an error getting hotels: " + response.ErrorMessage + " (" + response.StatusCode + ")");
                return new List<Hotel>();
            }

            return response.Data;
        }

        public List<Reservation> GetReservations(int hotelId = 0)
        {
            RestRequest request = new RestRequest(this.API_URL + "hotels/" + hotelId + "/reservations");

            IRestResponse<List<Reservation>> response = this.client.Get<List<Reservation>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not fetch a list of reservations");
                return new List<Reservation>();
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Encountered an error getting reservations: " + response.ErrorMessage + " (" + response.StatusCode + ")");
                return new List<Reservation>();
            }

            return response.Data;
        }

        public Reservation GetReservation(int reservationId)
        {
            RestRequest request = new RestRequest(this.API_URL + "reservations/" + reservationId);

            IRestResponse<Reservation> response = this.client.Get<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not fetch the specified reservation");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Encountered an error getting reservation: " + response.ErrorMessage + " (" + response.StatusCode + ")");
                return null;
            }

            return response.Data;
        }

        public Reservation AddReservation(Reservation newReservation)
        {
            RestRequest request = new RestRequest(this.API_URL + "reservations");

            request.AddJsonBody(newReservation);

            IRestResponse<Reservation> response = this.client.Post<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not add the specified reservation");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Encountered an error adding reservation: " + response.ErrorMessage + " (" + response.StatusCode + ")");
                return null;
            }

            return response.Data;
        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            RestRequest request = new RestRequest(this.API_URL + "reservations/" + reservationToUpdate.Id);

            request.AddJsonBody(reservationToUpdate);

            IRestResponse<Reservation> response = this.client.Put<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not update the specified reservation");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Encountered an error updating reservation: " + response.ErrorMessage + " (" + response.StatusCode + ")");
                return null;
            }

            return response.Data;
        }

        public bool DeleteReservation(int reservationId)
        {
            RestRequest request = new RestRequest(this.API_URL + "reservations/" + reservationId);

            IRestResponse response = this.client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not delete the specified reservation");
                return false;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Encountered an error deleting reservation: " + response.ErrorMessage + " (" + response.StatusCode + ")");
                return false;
            }

            return true;
        }
    }
}
