using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;
using Microsoft.AspNetCore.Http;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelDao hotelDao;
        private readonly IReservationDao reservationDao;

        public HotelsController(IHotelDao hotelDao, IReservationDao reservationDao)
        {
            this.hotelDao = hotelDao;
            this.reservationDao = reservationDao;
        }

        [HttpGet("hotels")]
        public ActionResult<List<Hotel>> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }
            else
            {
                return null;
            }
        }

        [HttpGet("hotels/filter")]
        public ActionResult<List<Hotel>> FilterByStateAndCity(string state, string city)
        {
            List<Hotel> filteredHotels = new List<Hotel>();

            List<Hotel> hotels = this.hotelDao.List();

            // return hotels that match state
            foreach (Hotel hotel in hotels)
            {
                if (city != null)
                {
                    // if city was passed we don't care about the state filter
                    if (hotel.Address.City.ToLower().Equals(city.ToLower()))
                    {
                        filteredHotels.Add(hotel);
                    }
                }
                else
                {
                    if (hotel.Address.State.ToLower().Equals(state.ToLower()))
                    {
                        filteredHotels.Add(hotel);
                    }
                }
            }
            return filteredHotels;
        }

        [HttpGet("reservations")]
        public ActionResult<List<Reservation>> ListReservations()
        {
            return reservationDao.List();
        }

        [HttpGet("reservations/{id}")]
        public ActionResult<Reservation> GetReservation(int id)
        {
            Reservation reservation = reservationDao.Get(id);

            if (reservation != null)
            {
                return reservation;
            }
            else
            {
                return null;
            }
        }

        [HttpGet("hotels/{hotelId}/reservations")]
        public ActionResult<List<Reservation>> ListReservationsByHotel(int hotelId)
        {
            Hotel hotel = hotelDao.Get(hotelId);
            if (hotel == null)
            {
                return NotFound("Could not find the specified hotel");
            }

            return reservationDao.FindByHotel(hotelId);
        }

        // Handle creating a reservation on /reservations POST
        [HttpPost("reservations")]
        public ActionResult<Reservation> AddReservation(Reservation newReservation)
        {
            Reservation result = this.reservationDao.Create(newReservation);

            return Created("reservations/" + result.Id, result);
        }

        // Handle updating a reservation on /reservations/{id} PUT
        [HttpPut("reservations/{id}")]
        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservation)
        {
            // TODO: Validate reservation Id matches
            if (reservation.Id != id)
            {
                return BadRequest("The ID of the Reservation must match the URL");
            }

            // TODO: Check that reservation exists
            Reservation existing = this.reservationDao.Get(id);
            if (existing == null)
            {
                return NotFound("Could not find the specified reservation");
            }

            return Ok(this.reservationDao.Update(id, reservation));
        }

        // Handle deleting a reservation on /reservations/{id} DELETE
        [HttpDelete("reservations/{id}")]
        public ActionResult DeleteReservation(int id)
        {
            // TODO: Check that reservation exists
            Reservation existing = this.reservationDao.Get(id);
            if (existing == null)
            {
                return NotFound("Could not find the specified reservation");
            }

            this.reservationDao.Delete(id);

            return NoContent();
            // return StatusCode(StatusCodes.Status418ImATeapot);
        }

    }
}
