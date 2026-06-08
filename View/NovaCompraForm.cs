using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_DA.Classes;
using Projeto_DA.Model;

namespace Projeto_DA.View
{
    
        public partial class NovaCompraForm : Form
        {
            private Utilizador _utilizadorLogado;
       

        public NovaCompraForm(Utilizador utilizadorLogado)
            {
                InitializeComponent();
                _utilizadorLogado = utilizadorLogado;

                ConfigurarFormulario();
            }

            private void ConfigurarFormulario()
            {
                this.Text = "Nova Compra - iShopping";
                this.StartPosition = FormStartPosition.CenterParent;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
            }

            // Evento do botão "Guardar" / "Criar Compra"
            private void btnGuardar_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textBoxNomeCompra.Text))
                {
                    MessageBox.Show("Por favor, introduza um nome para a compra.",
                                  "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (AppDbContext db = new AppDbContext())
                    {
                        
                        var novaCompra = new Compra
                        {
                            Name = textBoxNomeCompra.Text.Trim(),
                            DataCriacao = DateTime.Now,
                            Fechada = false,
                            UtilizadorCriacaoId = _utilizadorLogado.Id,
                            UtilizadorCriacao = _utilizadorLogado
                        };

                        db.Compras.Add(novaCompra);
                        db.SaveChanges();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar compra: {ex.Message}",
                                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        private void labelNovaCompraTitulo_Click(object sender, EventArgs e)
        {

        }

        
    }
    }

