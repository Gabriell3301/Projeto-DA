namespace Projeto_DA.View
{
    partial class ModoCompraForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrcamentoDisponivel = new System.Windows.Forms.Label();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.lblAlertaOrcamento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdAdiquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipoArtigo = new System.Windows.Forms.ComboBox();
            this.cmbArtigo = new System.Windows.Forms.ComboBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.numPrecoUnitario = new System.Windows.Forms.NumericUpDown();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnAdicionarNaoPrevisto = new System.Windows.Forms.Button();
            this.btnFecharCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCompra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrcamentoDisponivel
            // 
            this.lblOrcamentoDisponivel.AutoSize = true;
            this.lblOrcamentoDisponivel.Location = new System.Drawing.Point(114, 146);
            this.lblOrcamentoDisponivel.Name = "lblOrcamentoDisponivel";
            this.lblOrcamentoDisponivel.Size = new System.Drawing.Size(35, 13);
            this.lblOrcamentoDisponivel.TabIndex = 0;
            this.lblOrcamentoDisponivel.Text = "label1";
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Location = new System.Drawing.Point(74, 168);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(35, 13);
            this.lblTotalGastos.TabIndex = 1;
            this.lblTotalGastos.Text = "label2";
            // 
            // lblAlertaOrcamento
            // 
            this.lblAlertaOrcamento.AutoSize = true;
            this.lblAlertaOrcamento.Location = new System.Drawing.Point(193, 146);
            this.lblAlertaOrcamento.Name = "lblAlertaOrcamento";
            this.lblAlertaOrcamento.Size = new System.Drawing.Size(35, 13);
            this.lblAlertaOrcamento.TabIndex = 2;
            this.lblAlertaOrcamento.Text = "label3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Artigo,
            this.QtdPrevista,
            this.QtdAdiquirida,
            this.PrecoUnitario,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 128);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Artigo
            // 
            this.Artigo.HeaderText = "Artigo";
            this.Artigo.Name = "Artigo";
            // 
            // QtdPrevista
            // 
            this.QtdPrevista.HeaderText = "Qtd. Prevista";
            this.QtdPrevista.Name = "QtdPrevista";
            // 
            // QtdAdiquirida
            // 
            this.QtdAdiquirida.HeaderText = "Qtd. Adiquirida";
            this.QtdAdiquirida.Name = "QtdAdiquirida";
            // 
            // PrecoUnitario
            // 
            this.PrecoUnitario.HeaderText = "Preço Unitário";
            this.PrecoUnitario.Name = "PrecoUnitario";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // cmbTipoArtigo
            // 
            this.cmbTipoArtigo.FormattingEnabled = true;
            this.cmbTipoArtigo.Location = new System.Drawing.Point(625, 30);
            this.cmbTipoArtigo.Name = "cmbTipoArtigo";
            this.cmbTipoArtigo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoArtigo.TabIndex = 4;
            this.cmbTipoArtigo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoArtigo_SelectedIndexChanged_1);
            // 
            // cmbArtigo
            // 
            this.cmbArtigo.FormattingEnabled = true;
            this.cmbArtigo.Location = new System.Drawing.Point(625, 57);
            this.cmbArtigo.Name = "cmbArtigo";
            this.cmbArtigo.Size = new System.Drawing.Size(121, 21);
            this.cmbArtigo.TabIndex = 5;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(625, 84);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(120, 20);
            this.numQuantidade.TabIndex = 6;
            // 
            // numPrecoUnitario
            // 
            this.numPrecoUnitario.Location = new System.Drawing.Point(625, 110);
            this.numPrecoUnitario.Name = "numPrecoUnitario";
            this.numPrecoUnitario.Size = new System.Drawing.Size(120, 20);
            this.numPrecoUnitario.TabIndex = 7;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(646, 142);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(100, 20);
            this.txtObs.TabIndex = 8;
            // 
            // btnAdicionarNaoPrevisto
            // 
            this.btnAdicionarNaoPrevisto.Location = new System.Drawing.Point(642, 182);
            this.btnAdicionarNaoPrevisto.Name = "btnAdicionarNaoPrevisto";
            this.btnAdicionarNaoPrevisto.Size = new System.Drawing.Size(103, 35);
            this.btnAdicionarNaoPrevisto.TabIndex = 9;
            this.btnAdicionarNaoPrevisto.Text = "Adicionar Item Não Previsto";
            this.btnAdicionarNaoPrevisto.UseVisualStyleBackColor = true;
            this.btnAdicionarNaoPrevisto.Click += new System.EventHandler(this.btnAdicionarNaoPrevisto_Click);
            // 
            // btnFecharCompra
            // 
            this.btnFecharCompra.Location = new System.Drawing.Point(471, 146);
            this.btnFecharCompra.Name = "btnFecharCompra";
            this.btnFecharCompra.Size = new System.Drawing.Size(75, 35);
            this.btnFecharCompra.TabIndex = 10;
            this.btnFecharCompra.Text = "Fechar Compra";
            this.btnFecharCompra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo do Artigo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Artigo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantidade: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Preço Unitário: ";
            // 
            // txtNomeCompra
            // 
            this.txtNomeCompra.AutoSize = true;
            this.txtNomeCompra.Location = new System.Drawing.Point(624, 12);
            this.txtNomeCompra.Name = "txtNomeCompra";
            this.txtNomeCompra.Size = new System.Drawing.Size(35, 13);
            this.txtNomeCompra.TabIndex = 15;
            this.txtNomeCompra.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Compra: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Observações: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Orçamento Disponivel: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Gasto: ";
            // 
            // ModoCompraForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 244);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeCompra);
            this.Controls.Add(this.btnFecharCompra);
            this.Controls.Add(this.btnAdicionarNaoPrevisto);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.numPrecoUnitario);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.cmbArtigo);
            this.Controls.Add(this.cmbTipoArtigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAlertaOrcamento);
            this.Controls.Add(this.lblTotalGastos);
            this.Controls.Add(this.lblOrcamentoDisponivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "ModoCompraForms";
            this.Text = "ModoCompraForms";
            this.Load += new System.EventHandler(this.ModoCompraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrcamentoDisponivel;
        private System.Windows.Forms.Label lblTotalGastos;
        private System.Windows.Forms.Label lblAlertaOrcamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbTipoArtigo;
        private System.Windows.Forms.ComboBox cmbArtigo;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.NumericUpDown numPrecoUnitario;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnAdicionarNaoPrevisto;
        private System.Windows.Forms.Button btnFecharCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNomeCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdAdiquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}