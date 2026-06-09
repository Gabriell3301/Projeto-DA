using Projeto_DA.Classes;
using System;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_DA.View
{
    public partial class ArtigosForms : Form
    {
        private int? _editandoId = null;
        public ArtigosForms()
        {
            InitializeComponent();
            CarregarTipos();
            CarregarArtigos();
        }

        private void CarregarTipos()
        {
            using (var db = new AppDbContext())
            {
                // Filtro
                cmbTipoArtigo.Items.Clear();
                cmbTipoArtigo.Items.Add("Todos");
                foreach (var t in db.TiposArtigos.ToList())
                    cmbTipoArtigo.Items.Add(t);
                cmbTipoArtigo.DisplayMember = "Nome";
                cmbTipoArtigo.SelectedIndex = 0;

                // ComboBox do formulário
                cmbTipoArtigoNovo.DataSource = db.TiposArtigos.ToList();
                cmbTipoArtigoNovo.DisplayMember = "Nome";
                cmbTipoArtigoNovo.ValueMember = "Id";
            }
        }

        private void CarregarArtigos()
        {
            using (var db = new AppDbContext())
            {
                var query = db.Artigos.Include(a => a.TipoArtigo).AsQueryable();

                if (cmbTipoArtigo.SelectedItem is TipoArtigo tipo)
                    query = query.Where(a => a.TipoArtigoId == tipo.Id);

                dataGridView1.Rows.Clear();
                foreach (var a in query.ToList())
                    dataGridView1.Rows.Add(a.Id, a.Nome, a.TipoArtigo?.Nome);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeArtigo.Text) || cmbTipoArtigoNovo.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    if (_editandoId == null)
                    {
                        db.Artigos.Add(new Artigo
                        {
                            Nome = txtNomeArtigo.Text.Trim(),
                            TipoArtigoId = (int)cmbTipoArtigoNovo.SelectedValue
                        });
                    }
                    else
                    {
                        var artigo = db.Artigos.Find(_editandoId);
                        artigo.Nome = txtNomeArtigo.Text.Trim();
                        artigo.TipoArtigoId = (int)cmbTipoArtigoNovo.SelectedValue;
                    }
                    db.SaveChanges();
                }
                Limpar();
                CarregarArtigos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            _editandoId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtNomeArtigo.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString();

            string nomeTipo = dataGridView1.CurrentRow.Cells[2].Value?.ToString();
            foreach (TipoArtigo t in cmbTipoArtigoNovo.Items)
                if (t.Nome == nomeTipo) { cmbTipoArtigoNovo.SelectedItem = t; break; }

            btnAdicionar.Text = "Guardar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Eliminar este artigo?", "Confirmar",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                using (var db = new AppDbContext())
                {
                    var artigo = db.Artigos.Find(id);
                    db.Artigos.Remove(artigo);
                    db.SaveChanges();
                }
                Limpar();
                CarregarArtigos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) => Limpar();

        private void cmbTipoArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarArtigos();
        }

        private void cmbTipoArtigoNovo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Limpar()
        {
            txtNomeArtigo.Text = "";
            cmbTipoArtigoNovo.SelectedIndex = -1;
            _editandoId = null;
            btnAdicionar.Text = "Adicionar";
        }
    }
}
