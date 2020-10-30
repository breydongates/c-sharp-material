using HotelReservations.Dao;
using HotelReservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservations.DAO
{
    public class FakeHotelDAO : IHotelDao
    {
        public Hotel Get(int id)
        {
            return new Hotel(id, "California", null, 3, 5, 42M, "CatPicture.jpg");
        }

        public List<Hotel> List()
        {
            return new List<Hotel>();
        }
    }
}
