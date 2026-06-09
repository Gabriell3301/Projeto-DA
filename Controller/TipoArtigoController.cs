using Projeto_DA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controller
{
    internal class TipoArtigoController
    {
        public static List<TipoArtigo> GetTodos()
        {
            using (var db = new AppDbContext())
                return db.TiposArtigos.ToList();
        }

        public static void Guardar(TipoArtigo t)
        {
            using (var db = new AppDbContext())
            {
                if (t.Id == 0)
                    db.TiposArtigos.Add(t);
                else
                {
                    var existente = db.TiposArtigos.Find(t.Id);
                    existente.Nome = t.Nome;
                }
                db.SaveChanges();
            }
        }

        public static void Eliminar(int id)
        {
            using (var db = new AppDbContext())
            {
                var t = db.TiposArtigos.Find(id);
                if (t != null)
                {
                    db.TiposArtigos.Remove(t);
                    db.SaveChanges();
                }
            }
        }
    }
}
