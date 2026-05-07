using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Classes
{
    internal class ItemCompra
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public Compra Compra { get; set; }
        public int? ArtigoId { get; set; }
        public Artigo Artigo { get; set; }
        public int QuantidadePrevista { get; set; }
        public int QuantidadeReal { get; set; }
        public decimal PrecoUnitario { get; set; }
        public bool EhPrevisto { get; set; }
        public string Observacoes { get; set; }


        public int UtilizadorCriacaoId { get; set; }
        public Utilizador UtilizadorCriacao { get; set; }

        public int? UtilizadorAlteracaoId { get; set; }
        public Utilizador UtilizadorAlteracao { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
