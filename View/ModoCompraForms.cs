using Projeto_DA.Classes;
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
    public partial class ModoCompraForms : Form
    {
        private int _compraId;
        private Utilizador _utilizadorLogado;
        public ModoCompraForms(int compraId, Utilizador utilizadorLogado)
        {
            InitializeComponent();
            _compraId = compraId;
            _utilizadorLogado = utilizadorLogado;
            CarregarTipos();
            CarregarDados();
            CarregarArtigos();
        }
        private void ModoCompraForm_Load(object sender, EventArgs e)
        {
            
        }
        // ── Carregar ──────────────────────────────────────────────────────────

        private void CarregarTipos()
        {
            using (var db = new AppDbContext())
            {
                cmbTipoArtigo.DataSource = db.TiposArtigos.ToList();
                cmbTipoArtigo.DisplayMember = "Nome";
                cmbTipoArtigo.ValueMember = "Id";
                cmbTipoArtigo.SelectedIndex = -1;
            }
        }
        private void CarregarArtigos()
        {
            using (var db = new AppDbContext())
            {
                var tipos = db.TiposArtigos.ToList();

                cmbTipoArtigo.DisplayMember = "Nome";
                cmbTipoArtigo.ValueMember = "Id";
                cmbTipoArtigo.DataSource = tipos; // Ligar a DataSource no fim evita bugs no evento!
            }
        }

        private void CarregarDados()
        {
            using (var db = new AppDbContext())
            {
                var compra = db.Compras
                    .Include("Itens.Artigo")
                    .FirstOrDefault(c => c.Id == _compraId);

                if (compra == null) return;

                txtNomeCompra.Text = compra.Nome;

                // Orçamento do mês atual
                var orc = db.Orcamentos.FirstOrDefault(
                    o => o.Mes == DateTime.Now.Month && o.Ano == DateTime.Now.Year);
                decimal orcamento = orc?.ValorMaximo ?? 0;

                // Total já gasto em compras fechadas este mês (excluindo esta)
                decimal jaGasto = db.Compras
                    .Where(c => c.Fechada &&
                           c.DataFecho.Value.Month == DateTime.Now.Month &&
                           c.DataFecho.Value.Year == DateTime.Now.Year)
                    .SelectMany(c => c.Itens)
                    .Sum(i => (decimal?)(i.QuantidadeReal * i.PrecoUnitario)) ?? 0;

                lblOrcamentoDisponivel.Text = $"Orçamento do mês: {orcamento:C2}";
                lblTotalGastos.Text = $"Já gasto: {jaGasto:C2}";

                dataGridView1.Rows.Clear();
                foreach (var item in compra.Itens)
                    dataGridView1.Rows.Add(
                        item.Id,
                        item.Artigo?.Nome,
                        item.EhPrevisto ? "Previsto" : "Não Previsto", // coluna extra
                        item.QuantidadePrevista,
                        item.QuantidadeReal,
                        item.PrecoUnitario
                    );

                AtualizarTotal(compra, jaGasto, orcamento);
            }
        }

        private void AtualizarTotal(Compra compra, decimal jaGasto, decimal orcamento)
        {
            decimal totalEstaCompra = compra.Itens
                .Sum(i => i.QuantidadeReal * i.PrecoUnitario);

            decimal disponivel = orcamento - jaGasto - totalEstaCompra;

            lblTotalGastos.Text = $"Total desta compra: {totalEstaCompra:C2}";
            lblOrcamentoDisponivel.Text = $"Disponível: {disponivel:C2}";

            if (disponivel < 0)
            {
                lblAlertaOrcamento.Text = "⚠ ORÇAMENTO ULTRAPASSADO!";
                lblAlertaOrcamento.Visible = true;
            }
            else
            {
                lblAlertaOrcamento.Visible = false;
            }
        }

        // ── Itens previstos: guardar qtd e preço ao editar célula ─────────────

        private void dgvItens_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value);
            int qtd = 0;
            decimal preco = 0;

            int.TryParse(row.Cells[3].Value?.ToString(), out qtd);       // QuantidadeReal
            decimal.TryParse(row.Cells[4].Value?.ToString(), out preco); // PrecoUnitario

            try
            {
                using (var db = new AppDbContext())
                {
                    var item = db.ItensCompra.Find(id);
                    if (item != null)
                    {
                        item.QuantidadeReal = qtd;
                        item.PrecoUnitario = preco;
                        item.UtilizadorAlteracaoId = _utilizadorLogado.Id;
                        item.DataAlteracao = DateTime.Now;
                        db.SaveChanges();
                    }
                }
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Itens NÃO previstos ───────────────────────────────────────────────

        private void cmbTipoArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoArtigo.SelectedItem == null) return;

            int tipoId = (int)cmbTipoArtigo.SelectedValue;
            using (var db = new AppDbContext())
            {
                cmbArtigo.DataSource = db.Artigos
                    .Where(a => a.TipoArtigoId == tipoId).ToList();
                cmbArtigo.DisplayMember = "Nome";
                cmbArtigo.ValueMember = "Id";
            }
        }

        private void btnAdicionarNaoPrevisto_Click(object sender, EventArgs e)
        {
            if (cmbArtigo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um artigo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    db.ItensCompra.Add(new ItemCompra
                    {
                        CompraId = _compraId,
                        ArtigoId = (int)cmbArtigo.SelectedValue,
                        EhPrevisto = false,
                        QuantidadePrevista = 0,
                        QuantidadeReal = (int)numQuantidade.Value,
                        PrecoUnitario = numPrecoUnitario.Value,
                        Observacoes = txtObs.Text.Trim(),
                        UtilizadorCriacaoId = _utilizadorLogado.Id,
                        DataCriacao = DateTime.Now
                    });
                    db.SaveChanges();
                }

                // Limpar campos
                cmbTipoArtigo.SelectedIndex = -1;
                cmbArtigo.DataSource = null;
                numQuantidade.Value = 1;
                numPrecoUnitario.Value = 0;
                txtObs.Text = "";

                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Fechar compra ─────────────────────────────────────────────────────
        private void btnFecharCompra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que quer fechar esta compra?",
                "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                using (var db = new AppDbContext())
                {
                    var compra = db.Compras.Find(_compraId);
                    compra.Fechada = true;
                    compra.DataFecho = DateTime.Now;
                    compra.UtilizadorFechoId = _utilizadorLogado.Id;
                    db.SaveChanges();
                }

                MessageBox.Show("Compra fechada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoArtigo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Se não houver nada selecionado, sai
            if (cmbTipoArtigo.SelectedValue == null)
                return;

            int tipoId = 0;

            // Se o WinForms enviar o objeto completo (comum no Load), extraímos o ID dele
            if (cmbTipoArtigo.SelectedValue is TipoArtigo tipoSelecionado)
            {
                tipoId = tipoSelecionado.Id;
            }
            // Se já for o ID propriamente dito (inteiro), fazemos a conversão direta
            else if (cmbTipoArtigo.SelectedValue is int idInteiro)
            {
                tipoId = idInteiro;
            }
            else
            {
                return; // Caso seja outro tipo inesperado, ignora
            }

            using (var db = new AppDbContext())
            {
                // Corrigido o espaço: de 'artigos Filtrados' para 'artigosFiltrados'
                // Confirmado que na tua classe Artigo o campo se chama exatamente TipoArtigoId
                var artigosFiltrados = db.Artigos
                    .Where(a => a.TipoArtigoId == tipoId)
                    .ToList();

                // Desvincula temporariamente para evitar loops de eventos e limpa
                cmbArtigo.DataSource = null;

                cmbArtigo.DataSource = artigosFiltrados;
                cmbArtigo.DisplayMember = "Nome";
                cmbArtigo.ValueMember = "Id";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
