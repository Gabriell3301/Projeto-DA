namespace Projeto_DA.View
{
    partial class PlaneamentoCompras
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
            this.dvgCompras = new System.Windows.Forms.DataGridView();
            this.btnNova = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilizador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nItens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCompras
            // 
            this.dvgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.DataCriação,
            this.Utilizador,
            this.Estado,
            this.nItens});
            this.dvgCompras.Location = new System.Drawing.Point(12, 12);
            this.dvgCompras.Name = "dvgCompras";
            this.dvgCompras.Size = new System.Drawing.Size(543, 150);
            this.dvgCompras.TabIndex = 0;
            // 
            // btnNova
            // 
            this.btnNova.Location = new System.Drawing.Point(165, 220);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(75, 23);
            this.btnNova.TabIndex = 1;
            this.btnNova.Text = "Nova";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(249, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.Location = new System.Drawing.Point(330, 220);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(75, 23);
            this.btnExportarCSV.TabIndex = 3;
            this.btnExportarCSV.Text = "Exportar CSV";
            this.btnExportarCSV.UseVisualStyleBackColor = true;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(225, 187);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 4;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtro por Estado: ";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // DataCriação
            // 
            this.DataCriação.HeaderText = "Data Criação";
            this.DataCriação.Name = "DataCriação";
            // 
            // Utilizador
            // 
            this.Utilizador.HeaderText = "Utilizador";
            this.Utilizador.Name = "Utilizador";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // nItens
            // 
            this.nItens.HeaderText = "N de Itens";
            this.nItens.Name = "nItens";
            // 
            // PlaneamentoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnExportarCSV);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.dvgCompras);
            this.Name = "PlaneamentoCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaneamentoCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCompras;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExportarCSV;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nItens;
        private System.Windows.Forms.Label label1;
    }
}