using System;
using System.Data.Entity;

namespace Projeto_DA.Model
{
    internal class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Utilizadores.Add(new Utilizador
            {
                Nome = "Admin",
                Username = "admin",
                Password = "admin123" 
            });
            // Seed initial data if necessary
            base.Seed(context);
        }
    }
}
