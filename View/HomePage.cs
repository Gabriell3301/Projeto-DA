using System;
using System.Windows.Forms;
using Projeto_DA.Model;
using System.Linq;
using System.Data.Entity;

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

            using (AppDbContext db = new AppDbContext())
            {
                var comprasEmAberto = db.Compras
                    .Include("UtilizadorCriacao")
                    .Where(c => !c.Fechada)
                    .ToList();
                foreach (var compra in comprasEmAberto)
                {
                    int numItens = compra.Itens.Count(i => i.EhPrevisto);
                    decimal valorEstimado = compra.Itens
                        .Where(i => i.EhPrevisto)
                        .Sum(i=> i.QuantidadePrevista * i.PrecoUnitario);

                    dgvComprasEmAberto.Rows.Add(
                        compra.Id, 
                        compra.Nome, 
                        compra.DataCriacao.ToString("dd/MM/yyyy"), 
                        compra.UtilizadorCriacao.Nome ?? "Desconecido",
                        numItens,
                        valorEstimado
                    );
                }
            }
        }

        //Eventos dos botões

        private void buttonNovaCompra_Click(object sender, EventArgs e)
        {

        //Abre o formulário para uma Nova Compra   
 
            using (var form = new NovaCompraForm(_utilizadorLogado))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CarregarComprasEmAberto(); // atualiza a lista
                    MessageBox.Show("Compra criada com sucesso!", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
            using (var form = new TipoArtigoForm())
            {
                form.ShowDialog();
            }
        }

        private void buttonArtigos_Click(object sender, EventArgs e)
        {
            using (var form = new ArtigosForms())
            {
                form.ShowDialog();
            }
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new UtilizadoresForms())
            {
                form.ShowDialog();
            }
        }

        private void artigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ArtigosForms())
            {
                form.ShowDialog();
            }
        }
    }
}