using System.IO;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_DA.View
{
    public partial class PlaneamentoCompras : Form
    {
        private Utilizador _utilizadorLogado;
        public PlaneamentoCompras(Utilizador utilizador)
        {
            InitializeComponent();
            _utilizadorLogado = utilizador;

            CarregarFiltros();
            CarregarCompras();
        }
        private void CarregarFiltros()
        {
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("Todas");
            cmbFiltro.Items.Add("Em Aberto");
            cmbFiltro.Items.Add("Fechadas");
            cmbFiltro.SelectedIndex = 0;
        }
        private void CarregarCompras()
        {
            using (var db = new AppDbContext())
            {
                var query = db.Compras.Include("UtilizadorCriacao").AsQueryable();

                if (cmbFiltro.SelectedItem?.ToString() == "Em Aberto")
                    query = query.Where(c => !c.Fechada);
                else if (cmbFiltro.SelectedItem?.ToString() == "Fechadas")
                    query = query.Where(c => c.Fechada);

                dvgCompras.Rows.Clear();
                foreach (var c in query.ToList())
                    dvgCompras.Rows.Add(
                        c.Id,
                        c.Nome,
                        c.DataCriacao.ToString("dd/MM/yyyy"),
                        c.UtilizadorCriacao?.Nome ?? "—",
                        c.Fechada ? "Fechada" : "Em Aberto"
                    );
            }
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            var form = new NovaCompraForm(_utilizadorLogado);
            form.ShowDialog();
            CarregarCompras(); // atualiza após criar
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dvgCompras.CurrentRow == null) return;

            int id = Convert.ToInt32(dvgCompras.CurrentRow.Cells[0].Value);
            bool fechada = dvgCompras.CurrentRow.Cells[4].Value?.ToString() == "Fechada";

            // Abre o formulário de edição — vais criar este no passo 7
            var form = new EditarCompraForm(id, _utilizadorLogado, fechada);
            form.ShowDialog();
            CarregarCompras();
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "CSV (*.csv)|*.csv";
            save.FileName = $"ComprasFechadas_{DateTime.Now:yyyyMMdd}.csv";

            if (save.ShowDialog() != DialogResult.OK)
                return;

            using (var db = new AppDbContext())
            {
                var comprasFechadas = db.Compras
                    .Include("Itens.Artigo")
                    .Where(c =>
                        c.Fechada &&
                        c.UtilizadorCriacaoId == _utilizadorLogado.Id)
                    .ToList();

                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    writer.WriteLine(
                        "NomeCompra;DataCriacao;DataFechada;NomeArtigo;ArtigoPrevisto;" +
                        "ArtigoNaoPrevisto;QuantidadePrevista;QuantidadeAdquirida;PrecoUnitario");

                    foreach (var compra in comprasFechadas)
                    {
                        foreach (var item in compra.Itens)
                        {
                            writer.WriteLine(
                                $"{compra.Nome};" +
                                $"{compra.DataCriacao:dd/MM/yyyy};" +
                                $"{compra.DataFecho:dd/MM/yyyy};" +
                                $"{item.Artigo?.Nome};" +
                                $"{(item.EhPrevisto ? "Sim" : "")};" +
                                $"{(!item.EhPrevisto ? "Sim" : "")};" +
                                $"{item.QuantidadePrevista};" +
                                $"{item.QuantidadeReal};" +
                                $"{item.PrecoUnitario}");
                        }
                    }
                }
            }

            MessageBox.Show(
                "CSV exportado com sucesso!",
                "Exportação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCompras();
        }
    }
}
