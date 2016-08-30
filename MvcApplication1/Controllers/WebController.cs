using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class WebController : ApiController
    {
        private ReservationRespository repo = ReservationRespository.Current;
        // GET api/web
        public IEnumerable<Reservation> GetAllReservations()
        {
            return repo.GetAll();
        }

        // GET api/web/5
        public Reservation GetReservation(int id)
        {
            return repo.Get(id);
        }

        // POST api/web
        [HttpPost]
        public Reservation CreateReservation(Reservation item)
        {
            return repo.Add(item);
        }

        // PUT api/web/5
        [HttpPut]
        public bool UpdateReservation(Reservation item)
        {
            return repo.Update(item);
        }

        // DELETE api/web/5
        public void DeleteReservation(int id)
        {
            repo.Remove(id);
        }
    }
}
