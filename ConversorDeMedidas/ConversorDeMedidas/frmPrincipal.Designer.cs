namespace ConversorDeMedidas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlMedidas = new System.Windows.Forms.Panel();
            this.numMedida7 = new System.Windows.Forms.NumericUpDown();
            this.numMedida6 = new System.Windows.Forms.NumericUpDown();
            this.numMedida5 = new System.Windows.Forms.NumericUpDown();
            this.numMedida4 = new System.Windows.Forms.NumericUpDown();
            this.numMedida3 = new System.Windows.Forms.NumericUpDown();
            this.numMedida2 = new System.Windows.Forms.NumericUpDown();
            this.numMedida1 = new System.Windows.Forms.NumericUpDown();
            this.lblMedida1 = new System.Windows.Forms.Label();
            this.lblMedida2 = new System.Windows.Forms.Label();
            this.lblMedida4 = new System.Windows.Forms.Label();
            this.lblMedida3 = new System.Windows.Forms.Label();
            this.lblMedida6 = new System.Windows.Forms.Label();
            this.lblMedida5 = new System.Windows.Forms.Label();
            this.lblMedida7 = new System.Windows.Forms.Label();
            this.lblMedidaTitulo = new System.Windows.Forms.Label();
            this.lblValorTitulo = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pnlMedidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMedidas
            // 
            this.pnlMedidas.Controls.Add(this.numMedida7);
            this.pnlMedidas.Controls.Add(this.numMedida6);
            this.pnlMedidas.Controls.Add(this.numMedida5);
            this.pnlMedidas.Controls.Add(this.numMedida4);
            this.pnlMedidas.Controls.Add(this.numMedida3);
            this.pnlMedidas.Controls.Add(this.numMedida2);
            this.pnlMedidas.Controls.Add(this.numMedida1);
            this.pnlMedidas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMedidas.Location = new System.Drawing.Point(172, 54);
            this.pnlMedidas.Name = "pnlMedidas";
            this.pnlMedidas.Size = new System.Drawing.Size(345, 327);
            this.pnlMedidas.TabIndex = 7;
            // 
            // numMedida7
            // 
            this.numMedida7.DecimalPlaces = 3;
            this.numMedida7.Location = new System.Drawing.Point(30, 291);
            this.numMedida7.Maximum = new decimal(new int[] {
            29360128,
            -60931939,
            42825,
            0});
            this.numMedida7.Name = "numMedida7";
            this.numMedida7.Size = new System.Drawing.Size(284, 33);
            this.numMedida7.TabIndex = 6;
            this.numMedida7.ThousandsSeparator = true;
            this.numMedida7.Enter += new System.EventHandler(this.LimparTextBoxs);
            // 
            // numMedida6
            // 
            this.numMedida6.DecimalPlaces = 3;
            this.numMedida6.Location = new System.Drawing.Point(30, 243);
            this.numMedida6.Maximum = new decimal(new int[] {
            29360128,
            -60931939,
            42825,
            0});
            this.numMedida6.Name = "numMedida6";
            this.numMedida6.Size = new System.Drawing.Size(284, 33);
            this.numMedida6.TabIndex = 5;
            this.numMedida6.ThousandsSeparator = true;
            this.numMedida6.Enter += new System.EventHandler(this.LimparTextBoxs);
            // 
            // numMedida5
            // 
            this.numMedida5.DecimalPlaces = 3;
            this.numMedida5.Location = new System.Drawing.Point(30, 195);
            this.numMedida5.Maximum = new decimal(new int[] {
            29360128,
            -60931939,
            42825,
            0});
            this.numMedida5.Name = "numMedida5";
            this.numMedida5.Size = new System.Drawing.Size(284, 33);
            this.numMedida5.TabIndex = 4;
            this.numMedida5.ThousandsSeparator = true;
            this.numMedida5.Enter += new System.EventHandler(this.LimparTextBoxs);
            // 
            // numMedida4
            // 
            this.numMedida4.DecimalPlaces = 3;
            this.numMedida4.Location = new System.Drawing.Point(30, 147);
            this.numMedida4.Maximum = new decimal(new int[] {
            29360128,
            -60931939,
            42825,
            0});
            this.numMedida4.Name = "numMedida4";
            this.numMedida4.Size = new System.Drawing.Size(284, 33);
            this.numMedida4.TabIndex = 3;
            this.numMedida4.ThousandsSeparator = true;
            this.numMedida4.Enter += new System.EventHandler(this.LimparTextBoxs);
            // 
            // numMedida3
            // 
            this.numMedida3.DecimalPlaces = 3;
            this.numMedida3.Location = new System.Drawing.Point(30, 99);
            this.numMedida3.Maximum = new decimal(new int[] {
            29360128,
            -60931939,
            42825,
            0});
            this.numMedida3.Name = "numMedida3";
            this.numMedida3.Size = new System.Drawing.Size(284, 33);
            this.numMedida3.TabIndex = 2;
            this.numMedida3.ThousandsSeparator = true;
            this.numMedida3.Enter += new System.EventHandler(this.LimparTextBoxs);
            // 
            // numMedida2
            // 
            this.numMedida2.DecimalPlaces = 3;
            this.numMedida2.Location = new System.Drawing.Point(30, 51);
            this.numMedida2.Maximum = new decimal(new int[] {
            29360128,
            -60931939,
            42825,
            0});
            this.numMedida2.Name = "numMedida2";
            this.numMedida2.Size = new System.Drawing.Size(284, 33);
            this.numMedida2.TabIndex = 1;
            this.numMedida2.ThousandsSeparator = true;
            this.numMedida2.Enter += new System.EventHandler(this.LimparTextBoxs);
            // 
            // numMedida1
            // 
            this.numMedida1.DecimalPlaces = 3;
            this.numMedida1.Location = new System.Drawing.Point(30, 3);
            this.numMedida1.Maximum = new decimal(new int[] {
            29360128,
            -60931939,
            42825,
            0});
            this.numMedida1.Name = "numMedida1";
            this.numMedida1.Size = new System.Drawing.Size(284, 33);
            this.numMedida1.TabIndex = 0;
            this.numMedida1.ThousandsSeparator = true;
            this.numMedida1.Enter += new System.EventHandler(this.LimparTextBoxs);
            // 
            // lblMedida1
            // 
            this.lblMedida1.AutoSize = true;
            this.lblMedida1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida1.Location = new System.Drawing.Point(70, 59);
            this.lblMedida1.Name = "lblMedida1";
            this.lblMedida1.Size = new System.Drawing.Size(39, 25);
            this.lblMedida1.TabIndex = 8;
            this.lblMedida1.Text = "Km";
            // 
            // lblMedida2
            // 
            this.lblMedida2.AutoSize = true;
            this.lblMedida2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida2.Location = new System.Drawing.Point(70, 107);
            this.lblMedida2.Name = "lblMedida2";
            this.lblMedida2.Size = new System.Drawing.Size(41, 25);
            this.lblMedida2.TabIndex = 9;
            this.lblMedida2.Text = "Hm";
            // 
            // lblMedida4
            // 
            this.lblMedida4.AutoSize = true;
            this.lblMedida4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida4.Location = new System.Drawing.Point(70, 203);
            this.lblMedida4.Name = "lblMedida4";
            this.lblMedida4.Size = new System.Drawing.Size(29, 25);
            this.lblMedida4.TabIndex = 11;
            this.lblMedida4.Text = "M";
            // 
            // lblMedida3
            // 
            this.lblMedida3.AutoSize = true;
            this.lblMedida3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida3.Location = new System.Drawing.Point(70, 155);
            this.lblMedida3.Name = "lblMedida3";
            this.lblMedida3.Size = new System.Drawing.Size(53, 25);
            this.lblMedida3.TabIndex = 10;
            this.lblMedida3.Text = "DAm";
            // 
            // lblMedida6
            // 
            this.lblMedida6.AutoSize = true;
            this.lblMedida6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida6.Location = new System.Drawing.Point(70, 299);
            this.lblMedida6.Name = "lblMedida6";
            this.lblMedida6.Size = new System.Drawing.Size(40, 25);
            this.lblMedida6.TabIndex = 13;
            this.lblMedida6.Text = "Cm";
            // 
            // lblMedida5
            // 
            this.lblMedida5.AutoSize = true;
            this.lblMedida5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida5.Location = new System.Drawing.Point(70, 251);
            this.lblMedida5.Name = "lblMedida5";
            this.lblMedida5.Size = new System.Drawing.Size(41, 25);
            this.lblMedida5.TabIndex = 12;
            this.lblMedida5.Text = "Dm";
            // 
            // lblMedida7
            // 
            this.lblMedida7.AutoSize = true;
            this.lblMedida7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida7.Location = new System.Drawing.Point(70, 347);
            this.lblMedida7.Name = "lblMedida7";
            this.lblMedida7.Size = new System.Drawing.Size(45, 25);
            this.lblMedida7.TabIndex = 14;
            this.lblMedida7.Text = "Mm";
            // 
            // lblMedidaTitulo
            // 
            this.lblMedidaTitulo.AutoSize = true;
            this.lblMedidaTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedidaTitulo.Location = new System.Drawing.Point(53, 9);
            this.lblMedidaTitulo.Name = "lblMedidaTitulo";
            this.lblMedidaTitulo.Size = new System.Drawing.Size(77, 25);
            this.lblMedidaTitulo.TabIndex = 15;
            this.lblMedidaTitulo.Text = "Medida";
            // 
            // lblValorTitulo
            // 
            this.lblValorTitulo.AutoSize = true;
            this.lblValorTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTitulo.Location = new System.Drawing.Point(317, 9);
            this.lblValorTitulo.Name = "lblValorTitulo";
            this.lblValorTitulo.Size = new System.Drawing.Size(56, 25);
            this.lblValorTitulo.TabIndex = 16;
            this.lblValorTitulo.Text = "Valor";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Location = new System.Drawing.Point(46, 403);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(156, 35);
            this.btnLimparCampos.TabIndex = 18;
            this.btnLimparCampos.Text = "Limpar campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.LimparTextBoxs);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(345, 403);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(172, 35);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.Calcular);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 461);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.lblValorTitulo);
            this.Controls.Add(this.lblMedidaTitulo);
            this.Controls.Add(this.lblMedida7);
            this.Controls.Add(this.lblMedida6);
            this.Controls.Add(this.lblMedida5);
            this.Controls.Add(this.lblMedida4);
            this.Controls.Add(this.lblMedida3);
            this.Controls.Add(this.lblMedida2);
            this.Controls.Add(this.lblMedida1);
            this.Controls.Add(this.pnlMedidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de medidas - v1.0";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlMedidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMedida7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedida1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMedidas;
        private System.Windows.Forms.Label lblMedida1;
        private System.Windows.Forms.Label lblMedida2;
        private System.Windows.Forms.Label lblMedida4;
        private System.Windows.Forms.Label lblMedida3;
        private System.Windows.Forms.Label lblMedida6;
        private System.Windows.Forms.Label lblMedida5;
        private System.Windows.Forms.Label lblMedida7;
        private System.Windows.Forms.Label lblMedidaTitulo;
        private System.Windows.Forms.Label lblValorTitulo;
        private System.Windows.Forms.NumericUpDown numMedida7;
        private System.Windows.Forms.NumericUpDown numMedida6;
        private System.Windows.Forms.NumericUpDown numMedida5;
        private System.Windows.Forms.NumericUpDown numMedida4;
        private System.Windows.Forms.NumericUpDown numMedida3;
        private System.Windows.Forms.NumericUpDown numMedida2;
        private System.Windows.Forms.NumericUpDown numMedida1;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnCalcular;
    }
}

