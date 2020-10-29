using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservations.Dao;
using HotelReservations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private IReservationDao dao;

        public ReservationsController(IReservationDao dao)
        {
            this.dao = dao;
        }

        [HttpGet]
        public List<Reservation> GetReservations()
        {
            return this.dao.List();
        }
        
        [HttpGet("{reservationId}")]
        public Reservation GetReservation(int reservationId)
        {
            return this.dao.Get(reservationId);
        }

    }
}
