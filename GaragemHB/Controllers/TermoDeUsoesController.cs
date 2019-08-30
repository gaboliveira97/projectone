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
    public class TermoDeUsoesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/TermoDeUsoes
        public IQueryable<TermoDeUso> GettermoDeUso()
        {
            return db.TermoDeUso;
        }

        // GET: api/TermoDeUsoes/5
        [ResponseType(typeof(TermoDeUso))]
        public async Task<IHttpActionResult> GetTermoDeUso(int id)
        {
            TermoDeUso termoDeUso = await db.TermoDeUso.FindAsync(id);
            if (termoDeUso == null)
            {
                return NotFound();
            }

            return Ok(termoDeUso);
        }

        // PUT: api/TermoDeUsoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermoDeUso(int id, TermoDeUso termoDeUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termoDeUso.Id)
            {
                return BadRequest();
            }

            db.Entry(termoDeUso).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermoDeUsoExists(id))
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

        // POST: api/TermoDeUsoes
        [ResponseType(typeof(TermoDeUso))]
        public async Task<IHttpActionResult> PostTermoDeUso(TermoDeUso termoDeUso)
        {
          
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var termo = db.TermoDeUso.FirstOrDefault(x => x.Atual == true);
            if (termo != null)
                termo.Atual = false;

            db.TermoDeUso.Add(termoDeUso);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = termoDeUso.Id }, termoDeUso);
        }

        // DELETE: api/TermoDeUsoes/5
        [ResponseType(typeof(TermoDeUso))]
        public async Task<IHttpActionResult> DeleteTermoDeUso(int id)
        {
            TermoDeUso termoDeUso = await db.TermoDeUso.FindAsync(id);
            if (termoDeUso == null)
            {
                return NotFound();
            }

            db.TermoDeUso.Remove(termoDeUso);
            await db.SaveChangesAsync();

            return Ok(termoDeUso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermoDeUsoExists(int id)
        {
            return db.TermoDeUso.Count(e => e.Id == id) > 0;
        }
    }
}