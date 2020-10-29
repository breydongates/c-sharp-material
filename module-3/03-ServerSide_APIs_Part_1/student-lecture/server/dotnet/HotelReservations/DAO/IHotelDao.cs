using System.Collections.Generic;
using HotelReservations.Models;

namespace HotelReservations.Dao
{
    public interface IHotelDao
    {
        List<Hotel> List();

        List<Hotel> GetHotelsByCity(string city);

        List<Hotel> GetHotelsByState(string state);
        Hotel Get(int id);


    }
}
