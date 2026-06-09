using Projeto_DA.Classes;
using System;
using System.Windows.Forms;

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


        private void labelNovaCompraTitulo_Click(object sender, EventArgs e)
        {

        }

        // Evento do botão "Guardar" / "Criar Compra"
        private void buttonCriarCompra_Click(object sender, EventArgs e)
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
                        Nome = textBoxNomeCompra.Text.Trim(),
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

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

