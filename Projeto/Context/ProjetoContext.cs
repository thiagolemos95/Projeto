using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto.Context
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext() : base("Projeto")
        {

        }

        public DbSet<lancamento> lancamentos { get; set; }
    }
}