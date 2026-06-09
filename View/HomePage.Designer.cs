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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.dgvComprasEmAberto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilizador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumItensPrevistos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEstimado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNovaCompra = new System.Windows.Forms.Button();
            this.buttonFecharCompra = new System.Windows.Forms.Button();
            this.labelNomeApp = new System.Windows.Forms.Label();
            this.buttonAbrirCompra = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonTiposArtigos = new System.Windows.Forms.Button();
            this.buttonArtigos = new System.Windows.Forms.Button();
            this.buttonOrcamentos = new System.Windows.Forms.Button();
            this.buttonPlaneamentoCompras = new System.Windows.Forms.Button();
            this.buttonEstatisticas = new System.Windows.Forms.Button();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUtilizador = new System.Windows.Forms.Label();
            this.labelOrcamento = new System.Windows.Forms.Label();
            this.labelGasto = new System.Windows.Forms.Label();
            this.labelDisponivel = new System.Windows.Forms.Label();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEmAberto)).BeginInit();
            this.panelSideBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComprasEmAberto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComprasEmAberto.Location = new System.Drawing.Point(307, 81);
            this.dgvComprasEmAberto.Name = "dgvComprasEmAberto";
            this.dgvComprasEmAberto.RowHeadersWidth = 51;
            this.dgvComprasEmAberto.Size = new System.Drawing.Size(501, 357);
            this.dgvComprasEmAberto.TabIndex = 1;
            this.dgvComprasEmAberto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprasEmAberto_CellContentClick);
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
            // buttonNovaCompra
            // 
            this.buttonNovaCompra.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonNovaCompra.Location = new System.Drawing.Point(513, 361);
            this.buttonNovaCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNovaCompra.Name = "buttonNovaCompra";
            this.buttonNovaCompra.Size = new System.Drawing.Size(103, 28);
            this.buttonNovaCompra.TabIndex = 2;
            this.buttonNovaCompra.Text = "Nova Compra";
            this.buttonNovaCompra.UseVisualStyleBackColor = false;
            this.buttonNovaCompra.Click += new System.EventHandler(this.buttonNovaCompra_Click);
            // 
            // buttonFecharCompra
            // 
            this.buttonFecharCompra.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonFecharCompra.Location = new System.Drawing.Point(664, 361);
            this.buttonFecharCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFecharCompra.Name = "buttonFecharCompra";
            this.buttonFecharCompra.Size = new System.Drawing.Size(103, 28);
            this.buttonFecharCompra.TabIndex = 4;
            this.buttonFecharCompra.Text = "Fechar Compra";
            this.buttonFecharCompra.UseVisualStyleBackColor = false;
            this.buttonFecharCompra.Click += new System.EventHandler(this.buttonFecharCompra_Click);
            // 
            // labelNomeApp
            // 
            this.labelNomeApp.AutoSize = true;
            this.labelNomeApp.Location = new System.Drawing.Point(-2, 23);
            this.labelNomeApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeApp.Name = "labelNomeApp";
            this.labelNomeApp.Size = new System.Drawing.Size(0, 13);
            this.labelNomeApp.TabIndex = 8;
            // 
            // buttonAbrirCompra
            // 
            this.buttonAbrirCompra.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonAbrirCompra.Location = new System.Drawing.Point(363, 361);
            this.buttonAbrirCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAbrirCompra.Name = "buttonAbrirCompra";
            this.buttonAbrirCompra.Size = new System.Drawing.Size(103, 28);
            this.buttonAbrirCompra.TabIndex = 9;
            this.buttonAbrirCompra.Text = "Abrir Compra";
            this.buttonAbrirCompra.UseVisualStyleBackColor = false;
            this.buttonAbrirCompra.Click += new System.EventHandler(this.buttonAbrirCompra_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(8, 0);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(206, 35);
            this.buttonDashboard.TabIndex = 10;
            this.buttonDashboard.Text = "Painel Principal";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // buttonTiposArtigos
            // 
            this.buttonTiposArtigos.Location = new System.Drawing.Point(8, 60);
            this.buttonTiposArtigos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTiposArtigos.Name = "buttonTiposArtigos";
            this.buttonTiposArtigos.Size = new System.Drawing.Size(206, 35);
            this.buttonTiposArtigos.TabIndex = 11;
            this.buttonTiposArtigos.Text = "Tipos de Artigos";
            this.buttonTiposArtigos.UseVisualStyleBackColor = true;
            this.buttonTiposArtigos.Click += new System.EventHandler(this.buttonTiposArtigos_Click);
            // 
            // buttonArtigos
            // 
            this.buttonArtigos.Location = new System.Drawing.Point(8, 130);
            this.buttonArtigos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonArtigos.Name = "buttonArtigos";
            this.buttonArtigos.Size = new System.Drawing.Size(206, 35);
            this.buttonArtigos.TabIndex = 12;
            this.buttonArtigos.Text = "Artigos";
            this.buttonArtigos.UseVisualStyleBackColor = true;
            this.buttonArtigos.Click += new System.EventHandler(this.buttonArtigos_Click);
            // 
            // buttonOrcamentos
            // 
            this.buttonOrcamentos.Location = new System.Drawing.Point(8, 193);
            this.buttonOrcamentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOrcamentos.Name = "buttonOrcamentos";
            this.buttonOrcamentos.Size = new System.Drawing.Size(206, 35);
            this.buttonOrcamentos.TabIndex = 13;
            this.buttonOrcamentos.Text = "Orçamentos";
            this.buttonOrcamentos.UseVisualStyleBackColor = true;
            this.buttonOrcamentos.Click += new System.EventHandler(this.buttonOrcamentos_Click);
            // 
            // buttonPlaneamentoCompras
            // 
            this.buttonPlaneamentoCompras.Location = new System.Drawing.Point(8, 259);
            this.buttonPlaneamentoCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlaneamentoCompras.Name = "buttonPlaneamentoCompras";
            this.buttonPlaneamentoCompras.Size = new System.Drawing.Size(206, 35);
            this.buttonPlaneamentoCompras.TabIndex = 14;
            this.buttonPlaneamentoCompras.Text = "Planeamento de Compras";
            this.buttonPlaneamentoCompras.UseVisualStyleBackColor = true;
            this.buttonPlaneamentoCompras.Click += new System.EventHandler(this.buttonPlaneamentoCompras_Click);
            // 
            // buttonEstatisticas
            // 
            this.buttonEstatisticas.Location = new System.Drawing.Point(8, 322);
            this.buttonEstatisticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEstatisticas.Name = "buttonEstatisticas";
            this.buttonEstatisticas.Size = new System.Drawing.Size(206, 35);
            this.buttonEstatisticas.TabIndex = 15;
            this.buttonEstatisticas.Text = "Estatísticas";
            this.buttonEstatisticas.UseVisualStyleBackColor = true;
            this.buttonEstatisticas.Click += new System.EventHandler(this.buttonEstatisticas_Click);
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.buttonEstatisticas);
            this.panelSideBar.Controls.Add(this.buttonPlaneamentoCompras);
            this.panelSideBar.Controls.Add(this.buttonOrcamentos);
            this.panelSideBar.Controls.Add(this.buttonArtigos);
            this.panelSideBar.Controls.Add(this.buttonTiposArtigos);
            this.panelSideBar.Controls.Add(this.buttonDashboard);
            this.panelSideBar.Location = new System.Drawing.Point(20, 81);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(246, 357);
            this.panelSideBar.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.utilizadoresToolStripMenuItem,
            this.artigosToolStripMenuItem,
            this.orçamentoToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // utilizadoresToolStripMenuItem
            // 
            this.utilizadoresToolStripMenuItem.Name = "utilizadoresToolStripMenuItem";
            this.utilizadoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.utilizadoresToolStripMenuItem.Text = "Utilizadores";
            this.utilizadoresToolStripMenuItem.Click += new System.EventHandler(this.utilizadoresToolStripMenuItem_Click);
            // 
            // artigosToolStripMenuItem
            // 
            this.artigosToolStripMenuItem.Name = "artigosToolStripMenuItem";
            this.artigosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.artigosToolStripMenuItem.Text = "Artigos";
            this.artigosToolStripMenuItem.Click += new System.EventHandler(this.artigosToolStripMenuItem_Click);
            // 
            // orçamentoToolStripMenuItem
            // 
            this.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            this.orçamentoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.orçamentoToolStripMenuItem.Text = "Orçamento";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // labelUtilizador
            // 
            this.labelUtilizador.AutoSize = true;
            this.labelUtilizador.BackColor = System.Drawing.Color.Transparent;
            this.labelUtilizador.Location = new System.Drawing.Point(289, 54);
            this.labelUtilizador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUtilizador.Name = "labelUtilizador";
            this.labelUtilizador.Size = new System.Drawing.Size(53, 13);
            this.labelUtilizador.TabIndex = 18;
            this.labelUtilizador.Text = "Utilizador:";
            // 
            // labelOrcamento
            // 
            this.labelOrcamento.AutoSize = true;
            this.labelOrcamento.Location = new System.Drawing.Point(289, 470);
            this.labelOrcamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrcamento.Name = "labelOrcamento";
            this.labelOrcamento.Size = new System.Drawing.Size(62, 13);
            this.labelOrcamento.TabIndex = 19;
            this.labelOrcamento.Text = "Orçamento:";
            // 
            // labelGasto
            // 
            this.labelGasto.AutoSize = true;
            this.labelGasto.Location = new System.Drawing.Point(481, 470);
            this.labelGasto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGasto.Name = "labelGasto";
            this.labelGasto.Size = new System.Drawing.Size(93, 13);
            this.labelGasto.TabIndex = 20;
            this.labelGasto.Text = "Orçamento Gasto:";
            // 
            // labelDisponivel
            // 
            this.labelDisponivel.AutoSize = true;
            this.labelDisponivel.Location = new System.Drawing.Point(685, 470);
            this.labelDisponivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDisponivel.Name = "labelDisponivel";
            this.labelDisponivel.Size = new System.Drawing.Size(116, 13);
            this.labelDisponivel.TabIndex = 21;
            this.labelDisponivel.Text = "Orçamento Disponível:";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(839, 507);
            this.Controls.Add(this.labelDisponivel);
            this.Controls.Add(this.labelGasto);
            this.Controls.Add(this.labelOrcamento);
            this.Controls.Add(this.labelUtilizador);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.buttonAbrirCompra);
            this.Controls.Add(this.labelNomeApp);
            this.Controls.Add(this.buttonFecharCompra);
            this.Controls.Add(this.buttonNovaCompra);
            this.Controls.Add(this.dgvComprasEmAberto);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEmAberto)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvComprasEmAberto;
        private System.Windows.Forms.Button buttonNovaCompra;
        private System.Windows.Forms.Button buttonFecharCompra;
        private System.Windows.Forms.Label labelNomeApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumItensPrevistos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEstimado;
        private System.Windows.Forms.Button buttonAbrirCompra;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonTiposArtigos;
        private System.Windows.Forms.Button buttonArtigos;
        private System.Windows.Forms.Button buttonOrcamentos;
        private System.Windows.Forms.Button buttonPlaneamentoCompras;
        private System.Windows.Forms.Button buttonEstatisticas;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.Windows.Forms.Label labelUtilizador;
        private System.Windows.Forms.Label labelOrcamento;
        private System.Windows.Forms.Label labelGasto;
        private System.Windows.Forms.Label labelDisponivel;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}