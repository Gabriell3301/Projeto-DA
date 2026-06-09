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
    public partial class EditarCompraForm : Form
    {
        int _compraId;
        Utilizador _utilizadorLogado;
        bool _fechada;
        Compra _compraAtual; // Guardamos a compra em memória para manipular os Itens

        public EditarCompraForm(int compraId, Utilizador utilizadorLogado, bool fechada)
        {
            InitializeComponent();
            _compraId = compraId;
            _utilizadorLogado = utilizadorLogado;
            _fechada = fechada;

        }

        private void EditarCompraForm_Load(object sender, EventArgs e)
        {
            CarregarArtigosComboBox();
            CarregarDadosCompra();

            if (_fechada)
            {
                btnAdicionarItem.Enabled = false;
                btnRemoverItem.Enabled = false;
                btnGuardar.Enabled = false;
                cmbTipoArtigo.Enabled = false;
                cmbArtigo.Enabled = false;
                MessageBox.Show ("Esta compra já está fechada. Não pode ser modificada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Opcional, se tiveres uma label de aviso
            }
        }
        private void CarregarArtigosComboBox()
        {
            using (var db = new AppDbContext())
            {
                var tipos = db.TiposArtigos.ToList();

                cmbTipoArtigo.DisplayMember = "Nome";
                cmbTipoArtigo.ValueMember = "Id";
                cmbTipoArtigo.DataSource = tipos; // Ligar a DataSource no fim evita bugs no evento!
            }
        }

        private void CarregarDadosCompra()
        {
            using (var db = new AppDbContext())
            {
                // O Include em cadeia carrega a Compra -> os Itens -> o Artigo de cada item -> o Tipo de cada artigo
                _compraAtual = db.Compras
                    .Include("Itens")
                    .Include("Itens.Artigo")
                    .Include("Itens.Artigo.TipoArtigo")
                    .FirstOrDefault(c => c.Id == _compraId);

                if (_compraAtual == null)
                {
                    MessageBox.Show("Compra não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Atualiza os textos do teu formulário
                txtNome.Text = _compraAtual.Nome;
                dataCriacao.Text = _compraAtual.DataCriacao.ToString("dd/MM/yyyy");

                // Chama o método que acabámos de corrigir
                AtualizarGridItens();
            }
        }
        private void AtualizarGridItens()
        {
            dataGridView1.Rows.Clear();

            using (var db = new AppDbContext())
            {
                foreach (var item in _compraAtual.Itens)
                {
                    string nomeTipo = "N/A";

                    if (item.Artigo != null)
                    {
                        var tipo = db.TiposArtigos
                            .FirstOrDefault(t => t.Id == item.Artigo.TipoArtigoId);

                        if (tipo != null)
                            nomeTipo = tipo.Nome;
                    }

                    string nomeArtigo = item.Artigo?.Nome ?? "Desconhecido";

                    dataGridView1.Rows.Add(
                        item.Id,
                        nomeTipo,
                        nomeArtigo,
                        item.QuantidadePrevista,
                        item.PrecoUnitario.ToString("F2")
                    );
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataCriacao_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (cmbArtigo.SelectedValue == null) return;

            int artigoId = Convert.ToInt32(cmbArtigo.SelectedValue);
            int quantidade = (int)numQuantidade.Value; // Ajusta para o nome do teu controlo de quantidade

            if (quantidade <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se o artigo já existe nesta lista de planeamento para não duplicar linhas do mesmo artigo
            var itemExistente = _compraAtual.Itens.FirstOrDefault(i => i.ArtigoId == artigoId);
            if (itemExistente != null)
            {
                itemExistente.QuantidadePrevista += quantidade;
            }
            else
            {
                // Criar o novo item de planeamento
                var novoItem = new ItemCompra
                {
                    CompraId = _compraId,
                    ArtigoId = artigoId,
                    QuantidadePrevista = quantidade,
                    EhPrevisto = true, // No planeamento todos são previstos
                    QuantidadeReal = 0,
                    PrecoUnitario = 0
                };

                // Como o include do EF traz objetos associados, vamos buscar o Artigo para ele aparecer na Grid antes de gravares
                using (var db = new AppDbContext())
                {
                    novoItem.Artigo = db.Artigos.Find(artigoId);
                }

                _compraAtual.Itens.Add(novoItem);
            }

            AtualizarGridItens();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            // Vamos buscar o ArtigoId ou o Id do Item da linha selecionada. 
            // Como os itens novos em memória não têm ID da BD (é 0), o mais seguro é buscar pelo Nome do Artigo ou correspondência direta.
            string nomeArtigo = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            var itemParaRemover = _compraAtual.Itens.FirstOrDefault(i => i.Artigo?.Nome == nomeArtigo);

            if (itemParaRemover != null)
            {
                _compraAtual.Itens.Remove(itemParaRemover);

                // Se o item já tinha ID da Base de Dados, vais ter de o remover explicitamente no botão Guardar.
                // Mas para a lista em memória, basta o Remove().

                AtualizarGridItens();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // Forçamos o Entity Framework a seguir a compra original da BD
                    var compraBD = db.Compras.Include("Itens").FirstOrDefault(c => c.Id == _compraId);

                    if (compraBD == null) return;

                    // 1. Remover da BD os itens que o utilizador apagou na interface
                    var itensParaApagar = compraBD.Itens
                        .Where(dbItem => !_compraAtual.Itens.Any(memItem => memItem.Id == dbItem.Id))
                        .ToList();

                    foreach (var item in itensParaApagar)
                    {
                        db.ItensCompra.Remove(item); // Ajusta para o nome do teu DbSet de itens se for diferente (ex: db.ItensCompra)
                    }

                    // 2. Atualizar ou Adicionar os itens atuais
                    foreach (var memItem in _compraAtual.Itens)
                    {
                        if (memItem.Id == 0)
                        {
                            // É um item novo, adicionamos à lista da BD
                            compraBD.Itens.Add(new ItemCompra
                            {
                                ArtigoId = memItem.ArtigoId,
                                QuantidadePrevista = memItem.QuantidadePrevista,
                                EhPrevisto = true,
                                QuantidadeReal = 0,
                                PrecoUnitario = 0
                            });
                        }
                        else
                        {
                            // Item já existia, atualizamos apenas a quantidade planeada
                            var dbItem = compraBD.Itens.FirstOrDefault(i => i.Id == memItem.Id);
                            if (dbItem != null)
                            {
                                dbItem.QuantidadePrevista = memItem.QuantidadePrevista;
                            }
                        }
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Planeamento guardado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fecha o ecrã e volta ao menu principal
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoArtigo_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
