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
        public OrcamentoForms()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Precisa verificar se o orçamento já existe nesse mês/ano
            int.TryParse(cmbMes.Text, out int mes);
            int ano = (int) numAno.Value;
            decimal valor = numValor.Value;

            using (var db = new AppDbContext())
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
