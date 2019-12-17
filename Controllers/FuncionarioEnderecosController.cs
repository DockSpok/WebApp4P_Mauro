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
using WebApp4P.Models;

namespace WebApp4P.Controllers
{
    public class FuncionarioEnderecosController : ApiController
    {
        private Db4PEntities db = new Db4PEntities();

        // GET: api/FuncionarioEnderecos
        public IQueryable<FuncionarioEndereco> GetFuncionarioEnderecos()
        {
            return db.FuncionarioEnderecos;
        }

        // GET: api/FuncionarioEnderecos/5
        [ResponseType(typeof(FuncionarioEndereco))]
        public IHttpActionResult GetFuncionarioEndereco(int id)
        {
            FuncionarioEndereco funcionarioEndereco = db.FuncionarioEnderecos.Find(id);
            if (funcionarioEndereco == null)
            {
                return NotFound();
            }

            return Ok(funcionarioEndereco);
        }

        // PUT: api/FuncionarioEnderecos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFuncionarioEndereco(int id, FuncionarioEndereco funcionarioEndereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != funcionarioEndereco.Id)
            {
                return BadRequest();
            }

            db.Entry(funcionarioEndereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuncionarioEnderecoExists(id))
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

        // POST: api/FuncionarioEnderecos
        [ResponseType(typeof(FuncionarioEndereco))]
        public IHttpActionResult PostFuncionarioEndereco(FuncionarioEndereco funcionarioEndereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FuncionarioEnderecos.Add(funcionarioEndereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = funcionarioEndereco.Id }, funcionarioEndereco);
        }

        // DELETE: api/FuncionarioEnderecos/5
        [ResponseType(typeof(FuncionarioEndereco))]
        public IHttpActionResult DeleteFuncionarioEndereco(int id)
        {
            FuncionarioEndereco funcionarioEndereco = db.FuncionarioEnderecos.Find(id);
            if (funcionarioEndereco == null)
            {
                return NotFound();
            }

            db.FuncionarioEnderecos.Remove(funcionarioEndereco);
            db.SaveChanges();

            return Ok(funcionarioEndereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FuncionarioEnderecoExists(int id)
        {
            return db.FuncionarioEnderecos.Count(e => e.Id == id) > 0;
        }
    }
}