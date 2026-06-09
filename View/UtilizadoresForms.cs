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
            using (var db = new AppDbContext())
            {
                dataGridView1.Rows.Clear();
                foreach (var u in db.Utilizadores.ToList())
                    dataGridView1.Rows.Add(u.Id, u.Nome, u.Username, "****");
            }
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
                    // Verificar username único
                    bool existe = db.Utilizadores.Any(u =>
                        u.Username == txtUtilizador.Text && u.Id != (_editandoId ?? 0));

                    if (existe)
                    {
                        MessageBox.Show("Username já existe.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (_editandoId == null)
                    {
                        db.Utilizadores.Add(new Utilizador
                        {
                            Nome = txtNome.Text.Trim(),
                            Username = txtUtilizador.Text.Trim(),
                            Password = txtSenha.Text
                        });
                    }
                    else
                    {
                        var u = db.Utilizadores.Find(_editandoId);
                        u.Nome = txtNome.Text.Trim();
                        u.Username = txtUtilizador.Text.Trim();
                        u.Password = txtSenha.Text;
                    }

                    db.SaveChanges();
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
                using (var db = new AppDbContext())
                {
                    var u = db.Utilizadores.Find(id);
                    db.Utilizadores.Remove(u);
                    db.SaveChanges();
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
    }
}
