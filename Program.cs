using Projeto_DA.Model;
using Projeto_DA.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LoginPage loginPage = new LoginPage();
            if (loginPage.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Login bem sucedido!");
                //Aqui entra o forms de pagina inicial que ainda não existe.
                HomePage home = new HomePage(loginPage.UtilizadorLogado);
                home.ShowDialog();
            }
        }
    }
}
