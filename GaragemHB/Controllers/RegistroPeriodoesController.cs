using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GaragemHB.Models;

namespace GaragemHB.Controllers
{
    public class RegistroPeriodoesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/RegistroPeriodoes
        public IQueryable<RegistroPeriodo> GetRegistroPeriodo()
        {
            return db.RegistroPeriodo;
        }

        // GET: api/RegistroPeriodoes/5
        [ResponseType(typeof(RegistroPeriodo))]
        public async Task<IHttpActionResult> GetRegistroPeriodo(int id)
        {
            RegistroPeriodo registroPeriodo = await db.RegistroPeriodo.FindAsync(id);
            if (registroPeriodo == null)
            {
                return NotFound();
            }

            return Ok(registroPeriodo);
        }

        // PUT: api/RegistroPeriodoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRegistroPeriodo(int id, RegistroPeriodo registroPeriodo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != registroPeriodo.Id)
            {
                return BadRequest();
            }

            db.Entry(registroPeriodo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistroPeriodoExists(id))
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

        // POST: api/RegistroPeriodoes
        [ResponseType(typeof(RegistroPeriodo))]
        public async Task<IHttpActionResult> PostRegistroPeriodo(RegistroPeriodo registroPeriodo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RegistroPeriodo.Add(registroPeriodo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = registroPeriodo.Id }, registroPeriodo);
        }

        // DELETE: api/RegistroPeriodoes/5
        [ResponseType(typeof(RegistroPeriodo))]
        public async Task<IHttpActionResult> DeleteRegistroPeriodo(int id)
        {
            RegistroPeriodo registroPeriodo = await db.RegistroPeriodo.FindAsync(id);
            if (registroPeriodo == null)
            {
                return NotFound();
            }

            db.RegistroPeriodo.Remove(registroPeriodo);
            await db.SaveChangesAsync();

            return Ok(registroPeriodo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RegistroPeriodoExists(int id)
        {
            return db.RegistroPeriodo.Count(e => e.Id == id) > 0;
        }
    }
}