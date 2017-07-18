namespace View
{
	partial class Interface
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPageReceita = new System.Windows.Forms.TabPage();
            this.dgvPartners = new System.Windows.Forms.DataGridView();
            this.tbNameCNPJ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailcnpj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cnpjtelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cnpjsituation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearchCNPJInfo = new System.Windows.Forms.Button();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabRates = new MetroFramework.Controls.MetroTabPage();
            this.textBoxCAD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxCurrencyValue = new System.Windows.Forms.TextBox();
            this.ButtonSearchCurrency = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.tabPageReceita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).BeginInit();
            this.metroTabRates.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPageReceita);
            this.metroTabControl1.Controls.Add(this.metroTabRates);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 56);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(658, 362);
            this.metroTabControl1.TabIndex = 6;
            // 
            // tabPageReceita
            // 
            this.tabPageReceita.BackColor = System.Drawing.Color.Transparent;
            this.tabPageReceita.Controls.Add(this.dgvPartners);
            this.tabPageReceita.Controls.Add(this.tbNameCNPJ);
            this.tabPageReceita.Controls.Add(this.label5);
            this.tabPageReceita.Controls.Add(this.emailcnpj);
            this.tabPageReceita.Controls.Add(this.label4);
            this.tabPageReceita.Controls.Add(this.cnpjtelephone);
            this.tabPageReceita.Controls.Add(this.label3);
            this.tabPageReceita.Controls.Add(this.cnpjsituation);
            this.tabPageReceita.Controls.Add(this.label2);
            this.tabPageReceita.Controls.Add(this.buttonSearchCNPJInfo);
            this.tabPageReceita.Controls.Add(this.maskedTextBoxCNPJ);
            this.tabPageReceita.Controls.Add(this.label1);
            this.tabPageReceita.Location = new System.Drawing.Point(4, 35);
            this.tabPageReceita.Name = "tabPageReceita";
            this.tabPageReceita.Size = new System.Drawing.Size(650, 323);
            this.tabPageReceita.TabIndex = 0;
            this.tabPageReceita.Text = "Receita";
            this.tabPageReceita.Click += new System.EventHandler(this.tabPageReceita_Click);
            // 
            // dgvPartners
            // 
            this.dgvPartners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartners.ColumnHeadersVisible = false;
            this.dgvPartners.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPartners.Location = new System.Drawing.Point(19, 131);
            this.dgvPartners.Name = "dgvPartners";
            this.dgvPartners.Size = new System.Drawing.Size(615, 177);
            this.dgvPartners.TabIndex = 17;
            // 
            // tbNameCNPJ
            // 
            this.tbNameCNPJ.Location = new System.Drawing.Point(436, 89);
            this.tbNameCNPJ.Name = "tbNameCNPJ";
            this.tbNameCNPJ.Size = new System.Drawing.Size(207, 20);
            this.tbNameCNPJ.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome:";
            // 
            // emailcnpj
            // 
            this.emailcnpj.Location = new System.Drawing.Point(436, 54);
            this.emailcnpj.Name = "emailcnpj";
            this.emailcnpj.Size = new System.Drawing.Size(207, 20);
            this.emailcnpj.TabIndex = 14;
            this.emailcnpj.TextChanged += new System.EventHandler(this.emailcnpj_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email do CNPJ:";
            // 
            // cnpjtelephone
            // 
            this.cnpjtelephone.Location = new System.Drawing.Point(119, 90);
            this.cnpjtelephone.Name = "cnpjtelephone";
            this.cnpjtelephone.Size = new System.Drawing.Size(207, 20);
            this.cnpjtelephone.TabIndex = 12;
            this.cnpjtelephone.TextChanged += new System.EventHandler(this.cnpjtelephone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone do CNPJ:";
            // 
            // cnpjsituation
            // 
            this.cnpjsituation.Location = new System.Drawing.Point(119, 50);
            this.cnpjsituation.Name = "cnpjsituation";
            this.cnpjsituation.Size = new System.Drawing.Size(207, 20);
            this.cnpjsituation.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Situação do CNPJ:";
            // 
            // buttonSearchCNPJInfo
            // 
            this.buttonSearchCNPJInfo.Location = new System.Drawing.Point(176, 11);
            this.buttonSearchCNPJInfo.Name = "buttonSearchCNPJInfo";
            this.buttonSearchCNPJInfo.Size = new System.Drawing.Size(75, 20);
            this.buttonSearchCNPJInfo.TabIndex = 8;
            this.buttonSearchCNPJInfo.Text = "Buscar";
            this.buttonSearchCNPJInfo.UseVisualStyleBackColor = true;
            this.buttonSearchCNPJInfo.Click += new System.EventHandler(this.buttonSearchCNPJInfo_Click);
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(58, 11);
            this.maskedTextBoxCNPJ.Mask = "99.999.999/9999-99";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBoxCNPJ.TabIndex = 7;
            this.maskedTextBoxCNPJ.Text = "16501555000157";
            this.maskedTextBoxCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCNPJ_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CNPJ:";
            // 
            // metroTabRates
            // 
            this.metroTabRates.Controls.Add(this.textBoxCAD);
            this.metroTabRates.Controls.Add(this.label8);
            this.metroTabRates.Controls.Add(this.textBoxUSD);
            this.metroTabRates.Controls.Add(this.label7);
            this.metroTabRates.Controls.Add(this.label6);
            this.metroTabRates.Controls.Add(this.BoxCurrencyValue);
            this.metroTabRates.Controls.Add(this.ButtonSearchCurrency);
            this.metroTabRates.HorizontalScrollbarBarColor = true;
            this.metroTabRates.Location = new System.Drawing.Point(4, 35);
            this.metroTabRates.Name = "metroTabRates";
            this.metroTabRates.Size = new System.Drawing.Size(650, 323);
            this.metroTabRates.TabIndex = 1;
            this.metroTabRates.Text = "Rates";
            this.metroTabRates.VerticalScrollbarBarColor = true;
            // 
            // textBoxCAD
            // 
            this.textBoxCAD.Location = new System.Drawing.Point(60, 102);
            this.textBoxCAD.Name = "textBoxCAD";
            this.textBoxCAD.Size = new System.Drawing.Size(48, 20);
            this.textBoxCAD.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "CAD";
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Location = new System.Drawing.Point(60, 58);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(48, 20);
            this.textBoxUSD.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "USD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Moeda:";
            // 
            // BoxCurrencyValue
            // 
            this.BoxCurrencyValue.Location = new System.Drawing.Point(71, 13);
            this.BoxCurrencyValue.Name = "BoxCurrencyValue";
            this.BoxCurrencyValue.Size = new System.Drawing.Size(37, 20);
            this.BoxCurrencyValue.TabIndex = 3;
            this.BoxCurrencyValue.Text = "BRL";
            this.BoxCurrencyValue.TabIndexChanged += new System.EventHandler(this.ButtonSearchCurrency_Click);
            this.BoxCurrencyValue.TabStopChanged += new System.EventHandler(this.ButtonSearchCurrency_Click);
            // 
            // ButtonSearchCurrency
            // 
            this.ButtonSearchCurrency.Location = new System.Drawing.Point(114, 13);
            this.ButtonSearchCurrency.Name = "ButtonSearchCurrency";
            this.ButtonSearchCurrency.Size = new System.Drawing.Size(62, 20);
            this.ButtonSearchCurrency.TabIndex = 2;
            this.ButtonSearchCurrency.Text = "Consultar";
            this.ButtonSearchCurrency.UseVisualStyleBackColor = true;
            this.ButtonSearchCurrency.Click += new System.EventHandler(this.ButtonSearchCurrency_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Interface";
            this.Text = "Treinamento";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPageReceita.ResumeLayout(false);
            this.tabPageReceita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).EndInit();
            this.metroTabRates.ResumeLayout(false);
            this.metroTabRates.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private System.Windows.Forms.TabPage tabPageReceita;
		private System.Windows.Forms.Button buttonSearchCNPJInfo;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxCNPJ;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cnpjsituation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cnpjtelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailcnpj;
        private System.Windows.Forms.TextBox tbNameCNPJ;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTabPage metroTabRates;
        private System.Windows.Forms.DataGridView dgvPartners;
        private System.Windows.Forms.TextBox BoxCurrencyValue;
        private System.Windows.Forms.Button ButtonSearchCurrency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCAD;
        private System.Windows.Forms.Label label8;
    }
}

