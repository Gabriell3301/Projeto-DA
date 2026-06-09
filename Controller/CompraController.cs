using Projeto_DA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controller
{
    internal class CompraController
    {
        public static List<Compra> GetEmAberto()
        {
            using (var db = new AppDbContext())
                return db.Compras.Include("UtilizadorCriacao").Include("Itens")
                    .Where(c => !c.Fechada).ToList();
        }

        public static List<Compra> GetFechadas()
        {
            using (var db = new AppDbContext())
                return db.Compras.Include("UtilizadorCriacao").Include("Itens")
                    .Where(c => c.Fechada).ToList();
        }

        public static Compra GetById(int id)
        {
            using (var db = new AppDbContext())
                return db.Compras
                    .Include("Itens.Artigo")
                    .FirstOrDefault(c => c.Id == id);
        }

        public static void Guardar(Compra c)
        {
            using (var db = new AppDbContext())
            {
                if (c.Id == 0)
                    db.Compras.Add(c);
                else
                {
                    var existente = db.Compras.Find(c.Id);
                    existente.Nome = c.Nome;
                }
                db.SaveChanges();
            }
        }

        public static void Fechar(int id, int utilizadorId)
        {
            using (var db = new AppDbContext())
            {
                var c = db.Compras.Find(id);
                if (c != null)
                {
                    c.Fechada = true;
                    c.DataFecho = DateTime.Now;
                    c.UtilizadorFechoId = utilizadorId;
                    db.SaveChanges();
                }
            }
        }
    }
}
