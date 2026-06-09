using Projeto_DA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controller
{
    internal class ArtigoController
    {
        public static List<Artigo> GetTodos()
        {
            using (var db = new AppDbContext())
                return db.Artigos.Include("TipoArtigo").ToList();
        }

        public static List<Artigo> GetPorTipo(int tipoId)
        {
            using (var db = new AppDbContext())
                return db.Artigos.Include("TipoArtigo")
                    .Where(a => a.TipoArtigoId == tipoId).ToList();
        }

        public static void Guardar(Artigo a)
        {
            using (var db = new AppDbContext())
            {
                if (a.Id == 0)
                    db.Artigos.Add(a);
                else
                {
                    var existente = db.Artigos.Find(a.Id);
                    existente.Nome = a.Nome;
                    existente.TipoArtigoId = a.TipoArtigoId;
                }
                db.SaveChanges();
            }
        }

        public static void Eliminar(int id)
        {
            using (var db = new AppDbContext())
            {
                var a = db.Artigos.Find(id);
                if (a != null)
                {
                    db.Artigos.Remove(a);
                    db.SaveChanges();
                }
            }
        }
    }
}
