using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Classes
{
    internal class TipoArtigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Artigo> Artigos { get; set; }
    }
}
