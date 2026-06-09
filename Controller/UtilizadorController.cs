using Projeto_DA.Classes;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_DA.Controller
{
    public static class UtilizadorController
    {
        public static Utilizador Autenticar(string username, string password)
        {
            using (var db = new AppDbContext())
                return db.Utilizadores.FirstOrDefault(
                    u => u.Username == username && u.Password == password);
        }

        public static bool UsernameExiste(string username, int excluirId = 0)
        {
            using (var db = new AppDbContext())
                return db.Utilizadores.Any(u => u.Username == username && u.Id != excluirId);
        }

        public static List<Utilizador> GetTodos()
        {
            using (var db = new AppDbContext())
                return db.Utilizadores.ToList();
        }

        public static void Guardar(Utilizador u)
        {
            using (var db = new AppDbContext())
            {
                if (u.Id == 0)
                    db.Utilizadores.Add(u);
                else
                {
                    var existente = db.Utilizadores.Find(u.Id);
                    existente.Nome = u.Nome;
                    existente.Username = u.Username;
                    existente.Password = u.Password;
                }
                db.SaveChanges();
            }
        }

        public static void Eliminar(int id)
        {
            using (var db = new AppDbContext())
            {
                var u = db.Utilizadores.Find(id);
                if (u != null)
                {
                    db.Utilizadores.Remove(u);
                    db.SaveChanges();
                }
            }
        }
    }
}