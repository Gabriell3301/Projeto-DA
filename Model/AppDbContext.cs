using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.Classes;

namespace Projeto_DA
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDbContext")
        {
        }
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        
    }
}
