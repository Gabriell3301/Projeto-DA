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
    public partial class HomePage : Form
    {
        public DataGridViewTextBoxColumn utilizador { get; }

        public HomePage()
        {
            InitializeComponent();
            Utilizador = utilizador;

            ConfigurarHomePage();
            CarregarComprasEmAberto();
        }



        private void CarregarComprasEmAberto()
        {
            dgvComprasEmAberto.Rows.Clear();

            
            dgvComprasEmAberto.Rows.Add(1, "Compras Semanais", DateTime.Now.AddDays(-3).ToString("dd/MM/yyyy"), utilizador.Name, 12, 245.50);
            dgvComprasEmAberto.Rows.Add(2, "Produtos de Higiene", DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"), utilizador.Name, 7, 89.30);
        }


        private void ConfigurarHomePage()
        {
            // Título da janela
            this.Text = "iShopping - Gestão de Compras Domésticas";
            this.WindowState = FormWindowState.Maximized;

            // Mostrar utilizador logado
            labelUtilizador.Text = $"Utilizador: {Utilizador.Name}";
        }

        private void buttonNovaCompra_Click(object sender, EventArgs e)
        {
            // Abrir formulário de nova compra planeada
            MessageBox.Show("Abrindo formulário de Nova Compra...", "Nova Compra");
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        

        private void buttonAbrirCompra_Click(object sender, EventArgs e)
        {
            if (dgvComprasEmAberto.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma compra primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int compraId = Convert.ToInt32(dgvComprasEmAberto.CurrentRow.Cells["Id"].Value);
            MessageBox.Show($"Abrindo Modo Compra - ID: {compraId}", "Modo Compra");
        }

        private void buttonFecharCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade de Fechar Compra em desenvolvimento.", "Informação");
        }
    }
}
