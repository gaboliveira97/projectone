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
    public class CoresController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Cores
        public IQueryable<Cores> Getcor()
        {
            return db.Cor;
        }

        // GET: api/Cores/5
        [ResponseType(typeof(Cores))]
        public async Task<IHttpActionResult> GetCores(int id)
        {
            Cores cores = await db.Cor.FindAsync(id);
            if (cores == null)
            {
                return NotFound();
            }

            return Ok(cores);
        }

        // PUT: api/Cores/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCores(int id, Cores cores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cores.Id)
            {
                return BadRequest();
            }

            db.Entry(cores).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoresExists(id))
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

        // POST: api/Cores
        [ResponseType(typeof(Cores))]
        public async Task<IHttpActionResult> PostCores(Cores cores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cor.Add(cores);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cores.Id }, cores);
        }

        // DELETE: api/Cores/5
        [ResponseType(typeof(Cores))]
        public async Task<IHttpActionResult> DeleteCores(int id)
        {
            Cores cores = await db.Cor.FindAsync(id);
            if (cores == null)
            {
                return NotFound();
            }

            db.Cor.Remove(cores);
            await db.SaveChangesAsync();

            return Ok(cores);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CoresExists(int id)
        {
            return db.Cor.Count(e => e.Id == id) > 0;
        }
    }
}