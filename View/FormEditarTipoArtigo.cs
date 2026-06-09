using Microsoft.Win32;
using Projeto_DA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.View
{
    public partial class FormEditarTipoArtigo : Form
    {
        private int _id;
        public FormEditarTipoArtigo(int id)
        {
            _id = id;
            InitializeComponent();
            using (var db = new AppDbContext())
            {
                var tipoAntigo = db.TiposArtigos.Find(id);
                txtNome.Text = tipoAntigo.Nome;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                TipoArtigo tipo = db.TiposArtigos.Find(_id);

                tipo.Nome = txtNome.Text;

                db.SaveChanges();
            }

            MessageBox.Show("Tipo de artigo atualizado com sucesso!");

            this.Close();
        }
    }
}
