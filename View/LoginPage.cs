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
        public LoginPage()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

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
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Username ou Password incorretos");
                }


                // Se o login for bem-sucedido, abre a HomePage
                if (utilizador != null)
                {
                    this.Hide();
                    HomePage home = new HomePage(utilizador);   
                    home.ShowDialog();
                    this.Close();
                }

            }
        }
    }
}


