using Projeto_DA.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class LoginPage : Form
    {
        public Utilizador UtilizadorLogado { get; private set; }
        public LoginPage()
        {
            InitializeComponent();
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = UserText.Text.Trim();
            string password = PassText.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Deve introduzir as suas credenciais");
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                Utilizador utilizador = db.Utilizadores.FirstOrDefault(u => u.Username == login
                && u.Password == password);

                if (utilizador != null)
                {
                    this.DialogResult = DialogResult.OK;
                    UtilizadorLogado = utilizador;
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Username ou Password incorretos");
                }
            }
        }
    }
}


