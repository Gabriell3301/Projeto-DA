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
    public partial class OrcamentoForms : Form
    {
        private int? _editandoId = null;
        private Utilizador _utilizadorLogado;
        public OrcamentoForms(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            _utilizadorLogado = utilizadorLogado;
            CarregarMeses();
            CarregarOrcamentos();
        }


        private void CarregarMeses()
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                               "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            cmbMes.Items.Clear();
            for (int i = 0; i < meses.Length; i++)
                cmbMes.Items.Add(new { Texto = meses[i], Valor = i + 1 });

            cmbMes.DisplayMember = "Texto";
            cmbMes.SelectedIndex = DateTime.Now.Month - 1; // mês atual por defeito
            numAno.Value = (decimal)DateTime.Now.Year;
        }
        private void CarregarOrcamentos()
        {
            using (var db = new AppDbContext())
            {
                dataGridView1.Rows.Clear();
                foreach (var o in db.Orcamentos.Include("UtilizadorCriacao").ToList())
                    dataGridView1.Rows.Add(o.Id, o.Mes, o.Ano, o.ValorMaximo,
                        o.UtilizadorCriacao?.Nome ?? "—");
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Precisa verificar se o orçamento já existe nesse mês/ano
            if (cmbMes.SelectedItem == null)
            {
                MessageBox.Show("Selecione o mês.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int mes = (int)((dynamic)cmbMes.SelectedItem).Valor;
            int ano = (int)numAno.Value;
            decimal valor = numValor.Value;

            try
            {
                using (var db = new AppDbContext())
                {
                    // Verificar se já existe orçamento nesse mês/ano
                    bool existe = db.Orcamentos.Any(o =>
                        o.Mes == mes && o.Ano == ano && o.Id != (_editandoId ?? 0));

                    if (existe)
                    {
                        MessageBox.Show("Já existe um orçamento para esse mês/ano.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (_editandoId == null)
                    {
                        db.Orcamentos.Add(new Orcamento
                        {
                            Mes = mes,
                            Ano = ano,
                            ValorMaximo = valor,
                            UtilizadorCriacaoId = _utilizadorLogado.Id,
                            DataCriacao = DateTime.Now
                        });
                    }
                    else
                    {
                        var orc = db.Orcamentos.Find(_editandoId);
                        orc.Mes = mes;
                        orc.Ano = ano;
                        orc.ValorMaximo = valor;
                        orc.UtilizadorAlteracaoId = _utilizadorLogado.Id;
                        orc.DataAlteracao = DateTime.Now;
                    }

                    db.SaveChanges();
                }

                Limpar();
                CarregarOrcamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            _editandoId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int mes = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            int ano = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            decimal valor = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);

            cmbMes.SelectedIndex = mes - 1;
            numAno.Value = ano;
            numValor.Value = valor;
            btnAdicionar.Text = "Guardar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Eliminar este orçamento?", "Confirmar",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                using (var db = new AppDbContext())
                {
                    var orc = db.Orcamentos.Find(id);
                    db.Orcamentos.Remove(orc);
                    db.SaveChanges();
                }
                Limpar();
                CarregarOrcamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpar()
        {
            cmbMes.SelectedIndex = DateTime.Now.Month - 1;
            numAno.Value = DateTime.Now.Year;
            numValor.Value = 1;
            _editandoId = null;
            btnAdicionar.Text = "Adicionar";
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrcamentoForms_Load(object sender, EventArgs e)
        {

        }
    }
}
