using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelDao _hotelDao;
        private readonly IReservationDao reservationDao;

        public HotelsController(IHotelDao hotelDao, IReservationDao reservationDao)
        {
            _hotelDao = hotelDao;
            this.reservationDao = reservationDao;
        }

        [HttpGet("hotels")]
        public List<Hotel> ListHotels()
        {
            return _hotelDao.List();
        }

        [HttpGet("hotels/filter")]
        public List<Hotel> FilterHotels(string city, string state)
        {
            if (! string.IsNullOrEmpty(city))
            {
                return this._hotelDao.GetHotelsByCity(city);
            }
            if(!string.IsNullOrEmpty(state))
            {
                return this._hotelDao.GetHotelsByState(state);
            }
            return this._hotelDao.List();
        }

        

        [HttpGet("hotels/{id}")]
        public Hotel GetHotel(int id)
        {
            Hotel hotel = _hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }

            return null;
        }

        [HttpGet("hotels/{hotelId}/reservations")]
        public List<Reservation> GetReservations(int hotelId)
        {
            return reservationDao.FindByHotel(hotelId);
        }


    }
}
