namespace Projeto_DA.View
{
    partial class HomePage
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
            this.buttonAbrirCompra = new System.Windows.Forms.Button();
            this.dgvComprasEmAberto = new System.Windows.Forms.DataGridView();
            this.buttonNovaCompra = new System.Windows.Forms.Button();
            this.buttonVerDetalhes = new System.Windows.Forms.Button();
            this.buttonFecharCompra = new System.Windows.Forms.Button();
            this.labelNomeApp = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilizador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumItensPrevistos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEstimado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEmAberto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAbrirCompra
            // 
            this.buttonAbrirCompra.Location = new System.Drawing.Point(192, 139);
            this.buttonAbrirCompra.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAbrirCompra.Name = "buttonAbrirCompra";
            this.buttonAbrirCompra.Size = new System.Drawing.Size(137, 32);
            this.buttonAbrirCompra.TabIndex = 0;
            this.buttonAbrirCompra.Text = "Abrir Compra";
            this.buttonAbrirCompra.UseVisualStyleBackColor = true;
            // 
            // dgvComprasEmAberto
            // 
            this.dgvComprasEmAberto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasEmAberto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.DataCriacao,
            this.Utilizador,
            this.NumItensPrevistos,
            this.ValorEstimado});
            this.dgvComprasEmAberto.Location = new System.Drawing.Point(372, 49);
            this.dgvComprasEmAberto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComprasEmAberto.Name = "dgvComprasEmAberto";
            this.dgvComprasEmAberto.RowHeadersWidth = 51;
            this.dgvComprasEmAberto.Size = new System.Drawing.Size(668, 439);
            this.dgvComprasEmAberto.TabIndex = 1;
            // 
            // buttonNovaCompra
            // 
            this.buttonNovaCompra.Location = new System.Drawing.Point(89, 203);
            this.buttonNovaCompra.Name = "buttonNovaCompra";
            this.buttonNovaCompra.Size = new System.Drawing.Size(137, 34);
            this.buttonNovaCompra.TabIndex = 2;
            this.buttonNovaCompra.Text = "Nova Compra";
            this.buttonNovaCompra.UseVisualStyleBackColor = true;
            this.buttonNovaCompra.Click += new System.EventHandler(this.buttonNovaCompra_Click);
            // 
            // buttonVerDetalhes
            // 
            this.buttonVerDetalhes.Location = new System.Drawing.Point(125, 243);
            this.buttonVerDetalhes.Name = "buttonVerDetalhes";
            this.buttonVerDetalhes.Size = new System.Drawing.Size(137, 30);
            this.buttonVerDetalhes.TabIndex = 3;
            this.buttonVerDetalhes.Text = "Ver Detalhes";
            this.buttonVerDetalhes.UseVisualStyleBackColor = true;
            // 
            // buttonFecharCompra
            // 
            this.buttonFecharCompra.Location = new System.Drawing.Point(112, 178);
            this.buttonFecharCompra.Name = "buttonFecharCompra";
            this.buttonFecharCompra.Size = new System.Drawing.Size(137, 35);
            this.buttonFecharCompra.TabIndex = 4;
            this.buttonFecharCompra.Text = "Fechar Compra";
            this.buttonFecharCompra.UseVisualStyleBackColor = true;
            // 
            // labelNomeApp
            // 
            this.labelNomeApp.AutoSize = true;
            this.labelNomeApp.Location = new System.Drawing.Point(12, 22);
            this.labelNomeApp.Name = "labelNomeApp";
            this.labelNomeApp.Size = new System.Drawing.Size(68, 16);
            this.labelNomeApp.TabIndex = 8;
            this.labelNomeApp.Text = "iShopping";
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome da Compra";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 125;
            // 
            // DataCriacao
            // 
            this.DataCriacao.HeaderText = "Data de Criação";
            this.DataCriacao.MinimumWidth = 6;
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.Width = 125;
            // 
            // Utilizador
            // 
            this.Utilizador.HeaderText = "Utilizador";
            this.Utilizador.MinimumWidth = 6;
            this.Utilizador.Name = "Utilizador";
            this.Utilizador.Width = 125;
            // 
            // NumItensPrevistos
            // 
            this.NumItensPrevistos.HeaderText = "Número de Itens Previstos";
            this.NumItensPrevistos.MinimumWidth = 6;
            this.NumItensPrevistos.Name = "NumItensPrevistos";
            this.NumItensPrevistos.Width = 125;
            // 
            // ValorEstimado
            // 
            this.ValorEstimado.HeaderText = "Valor Estimado";
            this.ValorEstimado.MinimumWidth = 6;
            this.ValorEstimado.Name = "ValorEstimado";
            this.ValorEstimado.Width = 125;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelNomeApp);
            this.Controls.Add(this.buttonFecharCompra);
            this.Controls.Add(this.buttonVerDetalhes);
            this.Controls.Add(this.buttonNovaCompra);
            this.Controls.Add(this.dgvComprasEmAberto);
            this.Controls.Add(this.buttonAbrirCompra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEmAberto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbrirCompra;
        private System.Windows.Forms.DataGridView dgvComprasEmAberto;
        private System.Windows.Forms.Button buttonNovaCompra;
        private System.Windows.Forms.Button buttonVerDetalhes;
        private System.Windows.Forms.Button buttonFecharCompra;
        private System.Windows.Forms.Label labelNomeApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumItensPrevistos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEstimado;
    }
}