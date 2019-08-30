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
    public class ValorsController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Valors
        public IQueryable<Valor> GetValor()
        {
            return db.Valor;
        }

        // GET: api/Valors/5
        [ResponseType(typeof(Valor))]
        public async Task<IHttpActionResult> GetValor(int id)
        {
            Valor valor = await db.Valor.FindAsync(id);
            if (valor == null)
            {
                return NotFound();
            }

            return Ok(valor);
        }

        // PUT: api/Valors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutValor(int id, Valor valor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != valor.Id)
            {
                return BadRequest();
            }

            db.Entry(valor).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ValorExists(id))
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

        // POST: api/Valors
        [ResponseType(typeof(Valor))]
        public async Task<IHttpActionResult> PostValor(Valor valor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Valor.Add(valor);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = valor.Id }, valor);
        }

        // DELETE: api/Valors/5
        [ResponseType(typeof(Valor))]
        public async Task<IHttpActionResult> DeleteValor(int id)
        {
            Valor valor = await db.Valor.FindAsync(id);
            if (valor == null)
            {
                return NotFound();
            }

            db.Valor.Remove(valor);
            await db.SaveChangesAsync();

            return Ok(valor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ValorExists(int id)
        {
            return db.Valor.Count(e => e.Id == id) > 0;
        }
    }
}