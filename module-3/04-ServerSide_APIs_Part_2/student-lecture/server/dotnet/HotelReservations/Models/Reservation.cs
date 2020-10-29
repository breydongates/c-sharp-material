using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    public class Reservation
    {
        public int? Id { get; set; }

        public int HotelID { get; set; }

        public string FullName { get; set; } // This really should be required and have length restrictions

        public string CheckinDate { get; set; } // This probably should be required

        public string CheckoutDate { get; set; } // This probably should be required

        public int Guests { get; set; } // It'd be nice to restrict this to a range

        public Reservation(int? id, int hotelId, string fullName, string checkinDate, string checkoutDate, int guests)
        {
            Id = id ?? new Random().Next(100, int.MaxValue);
            HotelID = hotelId;
            FullName = fullName;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            Guests = guests;
        }
    }
}
