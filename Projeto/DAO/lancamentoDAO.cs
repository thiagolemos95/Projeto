using Projeto.Context;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.DAO
{
    public class lancamentoDAO
    {
        private ProjetoContext context;

        public lancamentoDAO(ProjetoContext Db)
        {
            context = Db;
        }

        public void Adiciona(Lancamento lancamento)
        {
            context.lancamentos.Add(lancamento);
            context.SaveChanges();
        }
        public IEnumerable<Lancamento> Lista()
        {
            return context.lancamentos.ToList();
        }
    }
}