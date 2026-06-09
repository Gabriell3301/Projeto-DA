using Projeto_DA.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.View
{
    public partial class UtilizadoresForms : Form
    {
        private int? _editandoId = null;
        public UtilizadoresForms()
        {
            InitializeComponent();
            CarregarUtilizadores();
        }

        private void CarregarUtilizadores()
        {
            dataGridView1.Rows.Clear();
            foreach (var u in UtilizadorController.GetTodos())
                dataGridView1.Rows.Add(u.Id, u.Nome, u.Username, "****");
        }

        private void btnNovo_Click(object sender, EventArgs e) => Limpar();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtUtilizador.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    if (UtilizadorController.UsernameExiste(txtUtilizador.Text.Trim(), _editandoId ?? 0))
                    {
                        MessageBox.Show("Username já existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var u = new Utilizador
                    {
                        Id = _editandoId ?? 0,
                        Nome = txtNome.Text.Trim(),
                        Username = txtUtilizador.Text.Trim(),
                        Password = txtSenha.Text
                    };
                    UtilizadorController.Guardar(u);
                }

                Limpar();
                CarregarUtilizadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            _editandoId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
            txtUtilizador.Text = dataGridView1.CurrentRow.Cells[2].Value?.ToString();
            txtSenha.Text = "";  // limpar - utilizador reintroduz a password
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Eliminar este utilizador?", "Confirmar",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                UtilizadorController.Eliminar(id);
                Limpar();
                CarregarUtilizadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpar()
        {
            txtNome.Text = "";
            txtUtilizador.Text = "";
            txtSenha.Text = "";
            _editandoId = null;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UtilizadoresForms_Load(object sender, EventArgs e)
        {

        }
    }
}
