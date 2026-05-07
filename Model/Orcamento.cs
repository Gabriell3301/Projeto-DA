using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Classes
{
    internal class Orcamento
    {
        public int Id { get; set; }
        public decimal ValorMaximo { get; set; }
        public int Mes { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int Ano { get; set; }

        public int UtilizadorCriacaoId { get; set; }
        public Utilizador UtilizadorCriacao { get; set; }

        public int? UtilizadorAlteracaoId { get; set; }
        public Utilizador UtilizadorAlteracao { get; set; }
    }
}
