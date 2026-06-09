namespace Projeto_DA.View
{
    partial class EstatisticaFroms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MesAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.nomeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFecho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perprevisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNaoprevisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSugerirOrcamento = new System.Windows.Forms.Button();
            this.dgvSugestaoLista = new System.Windows.Forms.DataGridView();
            this.btnSugerirLista = new System.Windows.Forms.Button();
            this.dgvOrcamentos = new System.Windows.Forms.DataGridView();
            this.lblSugestaoOrcamento = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugestaoLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCompras);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MesAno,
            this.Orcamento,
            this.TotalCompras,
            this.Diferenca});
            this.dataGridView1.Location = new System.Drawing.Point(20, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // MesAno
            // 
            this.MesAno.HeaderText = "Mês/Ano";
            this.MesAno.Name = "MesAno";
            // 
            // Orcamento
            // 
            this.Orcamento.HeaderText = "Orcamento";
            this.Orcamento.Name = "Orcamento";
            // 
            // TotalCompras
            // 
            this.TotalCompras.HeaderText = "Total compras";
            this.TotalCompras.Name = "TotalCompras";
            // 
            // Diferenca
            // 
            this.Diferenca.HeaderText = "Diferenca";
            this.Diferenca.Name = "Diferenca";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSemana);
            this.tabPage2.Controls.Add(this.lblSugestaoOrcamento);
            this.tabPage2.Controls.Add(this.dgvOrcamentos);
            this.tabPage2.Controls.Add(this.btnSugerirLista);
            this.tabPage2.Controls.Add(this.dgvSugestaoLista);
            this.tabPage2.Controls.Add(this.btnSugerirOrcamento);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeCompra,
            this.DataFecho,
            this.Perprevisto,
            this.perNaoprevisto});
            this.dgvCompras.Location = new System.Drawing.Point(20, 234);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(445, 151);
            this.dgvCompras.TabIndex = 3;
            // 
            // nomeCompra
            // 
            this.nomeCompra.HeaderText = "Nome Compra";
            this.nomeCompra.Name = "nomeCompra";
            // 
            // DataFecho
            // 
            this.DataFecho.HeaderText = "Data Fecho";
            this.DataFecho.Name = "DataFecho";
            // 
            // Perprevisto
            // 
            this.Perprevisto.HeaderText = "% previsto";
            this.Perprevisto.Name = "Perprevisto";
            // 
            // perNaoprevisto
            // 
            this.perNaoprevisto.HeaderText = "% Nao previsto";
            this.perNaoprevisto.Name = "perNaoprevisto";
            // 
            // btnSugerirOrcamento
            // 
            this.btnSugerirOrcamento.Location = new System.Drawing.Point(474, 299);
            this.btnSugerirOrcamento.Name = "btnSugerirOrcamento";
            this.btnSugerirOrcamento.Size = new System.Drawing.Size(75, 40);
            this.btnSugerirOrcamento.TabIndex = 0;
            this.btnSugerirOrcamento.Text = "Sugerir orcamento";
            this.btnSugerirOrcamento.UseVisualStyleBackColor = true;
            this.btnSugerirOrcamento.Click += new System.EventHandler(this.btnSugerirOrcamento_Click_1);
            // 
            // dgvSugestaoLista
            // 
            this.dgvSugestaoLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSugestaoLista.Location = new System.Drawing.Point(6, 54);
            this.dgvSugestaoLista.Name = "dgvSugestaoLista";
            this.dgvSugestaoLista.Size = new System.Drawing.Size(383, 150);
            this.dgvSugestaoLista.TabIndex = 1;
            // 
            // btnSugerirLista
            // 
            this.btnSugerirLista.Location = new System.Drawing.Point(474, 74);
            this.btnSugerirLista.Name = "btnSugerirLista";
            this.btnSugerirLista.Size = new System.Drawing.Size(75, 23);
            this.btnSugerirLista.TabIndex = 2;
            this.btnSugerirLista.Text = "Sugerir Lista";
            this.btnSugerirLista.UseVisualStyleBackColor = true;
            this.btnSugerirLista.Click += new System.EventHandler(this.btnSugerirLista_Click_1);
            // 
            // dgvOrcamentos
            // 
            this.dgvOrcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamentos.Location = new System.Drawing.Point(6, 247);
            this.dgvOrcamentos.Name = "dgvOrcamentos";
            this.dgvOrcamentos.Size = new System.Drawing.Size(383, 150);
            this.dgvOrcamentos.TabIndex = 3;
            // 
            // lblSugestaoOrcamento
            // 
            this.lblSugestaoOrcamento.AutoSize = true;
            this.lblSugestaoOrcamento.Location = new System.Drawing.Point(23, 216);
            this.lblSugestaoOrcamento.Name = "lblSugestaoOrcamento";
            this.lblSugestaoOrcamento.Size = new System.Drawing.Size(35, 13);
            this.lblSugestaoOrcamento.TabIndex = 4;
            this.lblSugestaoOrcamento.Text = "label1";
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Location = new System.Drawing.Point(23, 23);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(35, 13);
            this.lblSemana.TabIndex = 5;
            this.lblSemana.Text = "label2";
            // 
            // EstatisticaFroms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "EstatisticaFroms";
            this.Text = "EstatisticaFroms";
            this.Load += new System.EventHandler(this.EstatisticaFroms_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugestaoLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferenca;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFecho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perprevisto;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNaoprevisto;
        private System.Windows.Forms.DataGridView dgvSugestaoLista;
        private System.Windows.Forms.Button btnSugerirOrcamento;
        private System.Windows.Forms.Button btnSugerirLista;
        private System.Windows.Forms.DataGridView dgvOrcamentos;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label lblSugestaoOrcamento;
    }
}