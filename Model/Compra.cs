using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.Model;

namespace Projeto_DA.Classes
{
    internal class Compra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFecho { get; set; }
        public bool Fechada { get; set; }
        public int UtilizadorCriacaoId { get; set; }
        public Utilizador UtilizadorCriacao { get; set; }
        public int? UtilizadorFechoId { get; set; }
        public Utilizador UtilizadorFecho { get; set; }

        public List<ItemCompra> Itens { get; set; } = new List<ItemCompra>();
    }
}
