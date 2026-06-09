using Projeto_DA.Classes;
using Projeto_DA.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
            var tipos = TipoArtigoController.GetTodos();

            cmbTipoArtigo.Items.Clear();
            cmbTipoArtigo.Items.Add("Todos");
            foreach (var t in tipos)
                cmbTipoArtigo.Items.Add(t);
            cmbTipoArtigo.DisplayMember = "Nome";
            cmbTipoArtigo.SelectedIndex = 0;

            cmbTipoArtigoNovo.DataSource = TipoArtigoController.GetTodos();
            cmbTipoArtigoNovo.DisplayMember = "Nome";
            cmbTipoArtigoNovo.ValueMember = "Id";
        }

        private void CarregarArtigos()
        {
            List<Artigo> artigos;
            if (cmbTipoArtigo.SelectedItem is TipoArtigo tipo)
                artigos = ArtigoController.GetPorTipo(tipo.Id);
            else
                artigos = ArtigoController.GetTodos();

            dataGridView1.Rows.Clear();
            foreach (var a in artigos)
                dataGridView1.Rows.Add(a.Id, a.Nome, a.TipoArtigo?.Nome);
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
                var artigo = new Artigo
{
    Id = _editandoId ?? 0,
    Nome = txtNomeArtigo.Text.Trim(),
    TipoArtigoId = (int)cmbTipoArtigoNovo.SelectedValue
};
ArtigoController.Guardar(artigo);
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

        private void ArtigosForms_Load(object sender, EventArgs e)
        {

        }
    }
}
