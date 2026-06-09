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
                        .Sum(i => i.QuantidadePrevista * i.PrecoUnitario);

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
            if (dgvComprasEmAberto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona uma compra primeiro!");
                return;
            }

            var row = dgvComprasEmAberto.SelectedRows[0];

            int idCompra = Convert.ToInt32(row.Cells["Id"].Value);
            using (var form = new ModoCompraForms(idCompra, _utilizadorLogado))
            {
                form.ShowDialog();
            }
        }

        private void buttonFecharCompra_Click(object sender, EventArgs e)
        {
            if (dgvComprasEmAberto.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma compra primeiro.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem a certeza que quer fechar esta compra?",
                "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            int id = Convert.ToInt32(dgvComprasEmAberto.CurrentRow.Cells[0].Value);

            try
            {
                using (var db = new AppDbContext())
                {
                    var compra = db.Compras.Find(id);
                    compra.Fechada = true;
                    compra.DataFecho = DateTime.Now;
                    compra.UtilizadorFechoId = _utilizadorLogado.Id;
                    db.SaveChanges();
                }
                CarregarComprasEmAberto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarOrcamentoHomePage();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            AtualizarOrcamentoHomePage();
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

        private void dgvComprasEmAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOrcamentos_Click(object sender, EventArgs e)
        {
            using (var form = new OrcamentoForms(_utilizadorLogado))
            {
                form.ShowDialog();
            }
        }

        private void buttonPlaneamentoCompras_Click(object sender, EventArgs e)
        {
            using (var form = new PlaneamentoCompras(_utilizadorLogado))
            {
                form.ShowDialog();
                CarregarComprasEmAberto();
            }
        }

        private void buttonEstatisticas_Click(object sender, EventArgs e)
        {
            using (var form = new EstatisticaFroms())
            {
                form.ShowDialog();
            }
        }
        private void AtualizarOrcamentoHomePage()

        {
            using (var db = new AppDbContext())
            {

                var orc = db.Orcamentos.FirstOrDefault(
                o => o.Mes == DateTime.Now.Month && o.Ano == DateTime.Now.Year);
                decimal orcamento = orc?.ValorMaximo ?? 0;

                decimal gasto = db.Compras
                .Where(c => c.Fechada &&
                c.DataFecho.Value.Month == DateTime.Now.Month &&
                c.DataFecho.Value.Year == DateTime.Now.Year)
                .SelectMany(c => c.Itens)
                .Sum(i => (decimal?)(i.QuantidadeReal * i.PrecoUnitario)) ?? 0;

                labelOrcamento.Text = $"Orcamento: {orcamento:C2}";
                labelGasto.Text = $"Orcamento Gasto: {gasto:C2}";
                labelDisponivel.Text = $"Disponivel: {(orcamento - gasto):C2}";
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}