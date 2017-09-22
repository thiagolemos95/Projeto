using Projeto.DAO;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.Controllers
{
    public class HomeController : ApiController
    {
        private lancamentoDAO _lancamento;
        
        public HomeController(lancamentoDAO lancamento)
        {
            _lancamento = lancamento;
        }

        // GET: api/Home
        public IEnumerable<lancamento> Get()
        {
            return _lancamento.Lista();
        }

        // GET: api/Home/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
