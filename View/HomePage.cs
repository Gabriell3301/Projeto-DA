using System;
using System.Windows.Forms;
using Projeto_DA.Model;

namespace Projeto_DA.View
{
    public partial class HomePage : Form
    {
        public Utilizador _utilizadorLogado;

        // Construtor que recebe o utilizador do Login
        public HomePage(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            _utilizadorLogado = utilizadorLogado;

            ConfigurarHomePage();
            CarregarComprasEmAberto();
        }


        private void ConfigurarHomePage()
        {
            // Título da janela
            this.Text = "iShopping - Gestão de Compras Domésticas";
            this.WindowState = FormWindowState.Maximized;

            // Mostrar utilizador logado
            if (_utilizadorLogado != null)
            {
                labelUtilizador.Text = $"Utilizador: {_utilizadorLogado.Nome}";
            }
            else
            {
                labelUtilizador.Text = "Utilizador: Não identificado";
            }
        }

        private void CarregarComprasEmAberto()
        {
            dgvComprasEmAberto.Rows.Clear();

            // Dados de exemplo para ver se está a funcionar
            dgvComprasEmAberto.Rows.Add(1, "Compras Semanais",
                DateTime.Now.AddDays(-3).ToString("dd/MM/yyyy"),
                _utilizadorLogado?.Nome ?? "N/A", 12, 245.50);

            dgvComprasEmAberto.Rows.Add(2, "Produtos de Higiene",
                DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"),
                _utilizadorLogado?.Nome ?? "N/A", 7, 89.30);
        }

        //Eventos dos botões

        private void buttonNovaCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo formulário de Nova Compra...", "Nova Compra");
            //Em falta: Abrir o formulário de criação de nova compra
        }

        private void buttonAbrirCompra_Click(object sender, EventArgs e)
        {
            if (dgvComprasEmAberto.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma compra primeiro!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int compraId = Convert.ToInt32(dgvComprasEmAberto.CurrentRow.Cells["Id"].Value);
            MessageBox.Show($"Abrindo Modo Compra!", "Modo Compra");
        }

        private void buttonFecharCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade de Fechar Compra em desenvolvimento.", "Informação");
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonTiposArtigos_Click(object sender, EventArgs e)
        {

        }
    }
}