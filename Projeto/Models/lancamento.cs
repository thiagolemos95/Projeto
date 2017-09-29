using System;

namespace Projeto.Models
{
    public class Lancamento
    {
        public int Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataLancamento { get; set; }

        public string TipoLancamento { get; set; }

        public int Hora { get; set; }

        public int Minutos { get; set; }

        public int QuantidadePrevista { get; set; }

        public int QuantidadeRealizada { get; set; }

        public string Status { get; set; }

    }
}