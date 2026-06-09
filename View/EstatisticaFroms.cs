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
    public partial class EstatisticaFroms : Form
    {
        public EstatisticaFroms()
        {
            InitializeComponent();
            InicializarGrelhas();
            CarregarEstatisticasOrcamento();
            CarregarEstatisticasCompras();
        }

        private void EstatisticaFroms_Load(object sender, EventArgs e)
        {

        }
        private void InicializarGrelhas()
        {
            // ── dgvOrcamentos ─────────────────────────────────────────────────────
            dgvOrcamentos.Columns.Clear();
            dgvOrcamentos.Columns.Add("colMesAno", "Mês/Ano");
            dgvOrcamentos.Columns.Add("colOrcamento", "Orçamento");
            dgvOrcamentos.Columns.Add("colTotalGasto", "Total Gasto");
            dgvOrcamentos.Columns.Add("colDiferenca", "Diferença");
            dgvOrcamentos.ReadOnly = true;
            dgvOrcamentos.AllowUserToAddRows = false;
            dgvOrcamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ── dgvCompras ────────────────────────────────────────────────────────
            dgvCompras.Columns.Clear();
            dgvCompras.Columns.Add("colNome", "Nome Compra");
            dgvCompras.Columns.Add("colDataFecho", "Data Fecho");
            dgvCompras.Columns.Add("colPctPrevistos", "% Previstos");
            dgvCompras.Columns.Add("colPctNaoPrevistos", "% Não Previstos");
            dgvCompras.ReadOnly = true;
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ── dgvSugestaoLista ──────────────────────────────────────────────────
            dgvSugestaoLista.Columns.Clear();
            dgvSugestaoLista.Columns.Add("colArtigo", "Artigo");
            dgvSugestaoLista.Columns.Add("colQtdMedia", "Qtd. Média");
            dgvSugestaoLista.Columns.Add("colFrequencia", "Frequência");
            dgvSugestaoLista.ReadOnly = true;
            dgvSugestaoLista.AllowUserToAddRows = false;
            dgvSugestaoLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        // ── Separador 1 - Secção A: Orçamento por mês ────────────────────────

        private void CarregarEstatisticasOrcamento()
        {
            string[] meses = { "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                               "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            using (var db = new AppDbContext())
            {
                var orcamentos = db.Orcamentos.ToList();
                var comprasFechadas = db.Compras
                    .Include("Itens")
                    .Where(c => c.Fechada)
                    .ToList();

                dgvOrcamentos.Rows.Clear();

                foreach (var orc in orcamentos.OrderBy(o => o.Ano).ThenBy(o => o.Mes))
                {
                    // Total gasto em compras fechadas nesse mês/ano
                    decimal totalGasto = comprasFechadas
                        .Where(c => c.DataFecho.Value.Month == orc.Mes
                                 && c.DataFecho.Value.Year == orc.Ano)
                        .SelectMany(c => c.Itens)
                        .Sum(i => (decimal?)(i.QuantidadeReal * i.PrecoUnitario)) ?? 0;

                    decimal diferenca = orc.ValorMaximo - totalGasto;

                    dgvOrcamentos.Rows.Add(
                        $"{meses[orc.Mes]} {orc.Ano}",
                        orc.ValorMaximo.ToString("C2"),
                        totalGasto.ToString("C2"),
                        diferenca.ToString("C2")
                    );
                }
            }
        }

        // ── Separador 1 - Secção B: Compras fechadas com % de artigos ─────────

        private void CarregarEstatisticasCompras()
        {
            using (var db = new AppDbContext())
            {
                var compras = db.Compras
                    .Include("Itens")
                    .Where(c => c.Fechada)
                    .ToList();

                dgvCompras.Rows.Clear();

                foreach (var c in compras)
                {
                    int total = c.Itens.Count;
                    if (total == 0) continue;

                    int previstos = c.Itens.Count(i => i.EhPrevisto);
                    int naoPrevistos = total - previstos;

                    double pctPrevistos = Math.Round(previstos * 100.0 / total, 1);
                    double pctNaoPrevistos = Math.Round(naoPrevistos * 100.0 / total, 1);

                    dgvCompras.Rows.Add(
                        c.Nome,
                        c.DataFecho?.ToString("dd/MM/yyyy") ?? "—",
                        $"{pctPrevistos}%",
                        $"{pctNaoPrevistos}%"
                    );
                }
            }
        }

        // ── Separador 2 - Sugerir orçamento ──────────────────────────────────

        private void btnSugerirOrcamento_Click(object sender, EventArgs e)
        {
            
        }

        // ── Separador 2 - Sugerir lista de compras ────────────────────────────

        private void btnSugerirLista_Click_1(object sender, EventArgs e)
        {
            int semanaAtual = (DateTime.Now.Day - 1) / 7 + 1; // 1ª a 4ª semana do mês

            using (var db = new AppDbContext())
            {
                var comprasAnteriores = db.Compras
                    .Include("Itens.Artigo")
                    .Where(c => c.Fechada)
                    .ToList()
                    .Where(c => (c.DataCriacao.Day - 1) / 7 + 1 == semanaAtual)
                    .ToList();

                if (!comprasAnteriores.Any())
                {
                    lblSemana.Text = $"Semana atual: {semanaAtual}ª semana do mês";
                    dgvSugestaoLista.Rows.Clear();
                    dgvSugestaoLista.Rows.Add("Sem dados de compras anteriores nesta semana.");
                    return;
                }

                var sugestoes = comprasAnteriores
                    .SelectMany(c => c.Itens.Where(i => i.EhPrevisto))
                    .GroupBy(i => i.ArtigoId)
                    .OrderByDescending(g => g.Count())
                    .Take(10)
                    .Select(g => new
                    {
                        Artigo = g.First().Artigo?.Nome ?? "Desconhecido",
                        Frequencia = g.Count(),
                        QtdMedia = (int)Math.Round(g.Average(i => i.QuantidadePrevista))
                    })
                    .ToList();

                lblSemana.Text = $"Semana atual: {semanaAtual}ª semana do mês";
                dgvSugestaoLista.Rows.Clear();

                foreach (var s in sugestoes)
                    dgvSugestaoLista.Rows.Add(s.Artigo, s.QtdMedia, s.Frequencia);
            }
        }

        private void btnSugerirOrcamento_Click_1(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var orcamentos = db.Orcamentos.ToList();

                if (!orcamentos.Any())
                {
                    lblSugestaoOrcamento.Text = "Sem dados suficientes para sugerir um orçamento.";
                    return;
                }

                decimal media = orcamentos.Average(o => o.ValorMaximo);
                lblSugestaoOrcamento.Text = $"Orçamento sugerido para o próximo mês: {media:C2}";
            }
        }
    }
}
