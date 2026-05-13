using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using Projeto_DA.Model;

namespace Projeto_DA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new AppDbInitializer());
            using (AppDbContext db = new AppDbContext())
            {
                db.Database.Initialize(false);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new LoginPage().ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Login bem sucedido!");
                //Aqui entra o forms de pagina inicial que ainda não existe.
            }
        }
    }
}
