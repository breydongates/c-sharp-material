using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationsClient.Data
{
    public class LoginResult
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
