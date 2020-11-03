using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using portfolio_career_development.Models;

namespace portfolio_career_development.Controllers.Api
{
    public class WebinarsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Webinars
        public IQueryable<Webinar> GetWebinars()
        {
            return db.Webinars;
        }

        // GET: api/Webinars/5
        [ResponseType(typeof(Webinar))]
        public IHttpActionResult GetWebinar(int id)
        {
            Webinar webinar = db.Webinars.Find(id);
            if (webinar == null)
            {
                return NotFound();
            }

            return Ok(webinar);
        }

        // PUT: api/Webinars/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWebinar(int id, Webinar webinar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != webinar.Id)
            {
                return BadRequest();
            }

            db.Entry(webinar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebinarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Webinars
        [ResponseType(typeof(Webinar))]
        public IHttpActionResult PostWebinar(Webinar webinar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Webinars.Add(webinar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = webinar.Id }, webinar);
        }

        // DELETE: api/Webinars/5
        [ResponseType(typeof(Webinar))]
        public IHttpActionResult DeleteWebinar(int id)
        {
            Webinar webinar = db.Webinars.Find(id);
            if (webinar == null)
            {
                return NotFound();
            }

            db.Webinars.Remove(webinar);
            db.SaveChanges();

            return Ok(webinar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WebinarExists(int id)
        {
            return db.Webinars.Count(e => e.Id == id) > 0;
        }
    }
}