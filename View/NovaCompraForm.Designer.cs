namespace Projeto_DA.View
{
    partial class NovaCompraForm
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
            this.labelNovaCompraTitulo = new System.Windows.Forms.Label();
            this.textBoxNomeCompra = new System.Windows.Forms.TextBox();
            this.labelNomeCompra = new System.Windows.Forms.Label();
            this.labelDataCriacaoCompra = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelOrcamentop = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelEuro = new System.Windows.Forms.Label();
            this.buttonCriarCompra = new System.Windows.Forms.Button();
            this.buttonCancelarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNovaCompraTitulo
            // 
            this.labelNovaCompraTitulo.AutoSize = true;
            this.labelNovaCompraTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelNovaCompraTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovaCompraTitulo.Location = new System.Drawing.Point(22, 18);
            this.labelNovaCompraTitulo.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.labelNovaCompraTitulo.Name = "labelNovaCompraTitulo";
            this.labelNovaCompraTitulo.Size = new System.Drawing.Size(158, 26);
            this.labelNovaCompraTitulo.TabIndex = 0;
            this.labelNovaCompraTitulo.Text = "Nova Compra";
            this.labelNovaCompraTitulo.Click += new System.EventHandler(this.labelNovaCompraTitulo_Click);
            // 
            // textBoxNomeCompra
            // 
            this.textBoxNomeCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeCompra.Location = new System.Drawing.Point(24, 136);
            this.textBoxNomeCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNomeCompra.Multiline = true;
            this.textBoxNomeCompra.Name = "textBoxNomeCompra";
            this.textBoxNomeCompra.Size = new System.Drawing.Size(303, 65);
            this.textBoxNomeCompra.TabIndex = 6;
            // 
            // labelNomeCompra
            // 
            this.labelNomeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompra.Location = new System.Drawing.Point(23, 110);
            this.labelNomeCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeCompra.Name = "labelNomeCompra";
            this.labelNomeCompra.Size = new System.Drawing.Size(128, 23);
            this.labelNomeCompra.TabIndex = 7;
            this.labelNomeCompra.Text = "Nome da Compra";
            // 
            // labelDataCriacaoCompra
            // 
            this.labelDataCriacaoCompra.AutoSize = true;
            this.labelDataCriacaoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataCriacaoCompra.Location = new System.Drawing.Point(23, 234);
            this.labelDataCriacaoCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataCriacaoCompra.Name = "labelDataCriacaoCompra";
            this.labelDataCriacaoCompra.Size = new System.Drawing.Size(110, 17);
            this.labelDataCriacaoCompra.TabIndex = 8;
            this.labelDataCriacaoCompra.Text = "Data de Criação";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 253);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // labelOrcamentop
            // 
            this.labelOrcamentop.AutoSize = true;
            this.labelOrcamentop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrcamentop.Location = new System.Drawing.Point(26, 325);
            this.labelOrcamentop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrcamentop.Name = "labelOrcamentop";
            this.labelOrcamentop.Size = new System.Drawing.Size(140, 17);
            this.labelOrcamentop.TabIndex = 10;
            this.labelOrcamentop.Text = "Orçamento Estimado";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(24, 355);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(303, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEuro.Location = new System.Drawing.Point(96, 357);
            this.labelEuro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(13, 13);
            this.labelEuro.TabIndex = 12;
            this.labelEuro.Text = "€";
            // 
            // buttonCriarCompra
            // 
            this.buttonCriarCompra.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonCriarCompra.Location = new System.Drawing.Point(205, 439);
            this.buttonCriarCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCriarCompra.Name = "buttonCriarCompra";
            this.buttonCriarCompra.Size = new System.Drawing.Size(151, 28);
            this.buttonCriarCompra.TabIndex = 14;
            this.buttonCriarCompra.Text = "Criar Compra";
            this.buttonCriarCompra.UseVisualStyleBackColor = false;
            this.buttonCriarCompra.Click += new System.EventHandler(this.buttonCriarCompra_Click);
            // 
            // buttonCancelarCompra
            // 
            this.buttonCancelarCompra.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCancelarCompra.Location = new System.Drawing.Point(20, 439);
            this.buttonCancelarCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelarCompra.Name = "buttonCancelarCompra";
            this.buttonCancelarCompra.Size = new System.Drawing.Size(151, 28);
            this.buttonCancelarCompra.TabIndex = 15;
            this.buttonCancelarCompra.Text = "Cancelar";
            this.buttonCancelarCompra.UseVisualStyleBackColor = false;
            this.buttonCancelarCompra.Click += new System.EventHandler(this.buttonCancelarCompra_Click);
            // 
            // NovaCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 525);
            this.Controls.Add(this.buttonCancelarCompra);
            this.Controls.Add(this.buttonCriarCompra);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelOrcamentop);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDataCriacaoCompra);
            this.Controls.Add(this.labelNomeCompra);
            this.Controls.Add(this.textBoxNomeCompra);
            this.Controls.Add(this.labelNovaCompraTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NovaCompraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NovaCompraForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNovaCompraTitulo;
        private System.Windows.Forms.TextBox textBoxNomeCompra;
        private System.Windows.Forms.Label labelNomeCompra;
        private System.Windows.Forms.Label labelDataCriacaoCompra;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelOrcamentop;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Button buttonCriarCompra;
        private System.Windows.Forms.Button buttonCancelarCompra;
    }
}