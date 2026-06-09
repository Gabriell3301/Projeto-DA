using Projeto_DA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.View
{
    public partial class TipoArtigoForm : Form
    {
        public TipoArtigoForm()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            using (var db = new AppDbContext())
            {
                var tipos = db.TiposArtigos.ToList();
                dgvTiposArtigos.DataSource = tipos;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira um Nome para o novo tipo de artigo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            using (var db = new AppDbContext())
            {
                TipoArtigo tipo = new TipoArtigo()
                {
                    Nome = txtNome.Text
                };
                db.TiposArtigos.Add(tipo);
                db.SaveChanges();
            }
            MessageBox.Show("Tipo de Artigo criado com sucesso.", "Sucesso");
            CarregarDados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTiposArtigos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione/Clique em um tipo de artigo.");
                return;
            }

            int id = Convert.ToInt32(
                dgvTiposArtigos.SelectedRows[0].Cells["Id"].Value);

            FormEditarTipoArtigo form = new FormEditarTipoArtigo(id);

            form.ShowDialog();

            CarregarDados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTiposArtigos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione/Clique em um tipo de artigo.");
                return;
            }
            int id = Convert.ToInt32(
                dgvTiposArtigos.SelectedRows[0].Cells["Id"].Value);

            DialogResult resposta = MessageBox.Show(
               "Tem a certeza que deseja eliminar este tipo de artigo?",
               "Confirmação",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
                return;

            using (var db = new AppDbContext())
            {
                TipoArtigo tipo = db.TiposArtigos.Find(id);

                if (tipo == null)
                {
                    MessageBox.Show("Tipo de artigo não encontrado.");
                    return;
                }

                db.TiposArtigos.Remove(tipo);

                db.SaveChanges();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvTiposArtigos.ClearSelection();
            txtNome.Clear();
        }
    }
}
