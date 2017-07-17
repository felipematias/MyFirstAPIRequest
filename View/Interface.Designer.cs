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
			this.buttonSearchCNPJInfo = new System.Windows.Forms.Button();
			this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.metroTabControl1.SuspendLayout();
			this.tabPageReceita.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.tabPageReceita);
			this.metroTabControl1.Location = new System.Drawing.Point(23, 56);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(658, 362);
			this.metroTabControl1.TabIndex = 6;
			this.metroTabControl1.UseSelectable = true;
			// 
			// tabPageReceita
			// 
			this.tabPageReceita.BackColor = System.Drawing.Color.Transparent;
			this.tabPageReceita.Controls.Add(this.buttonSearchCNPJInfo);
			this.tabPageReceita.Controls.Add(this.maskedTextBoxCNPJ);
			this.tabPageReceita.Controls.Add(this.label1);
			this.tabPageReceita.Location = new System.Drawing.Point(4, 38);
			this.tabPageReceita.Name = "tabPageReceita";
			this.tabPageReceita.Size = new System.Drawing.Size(650, 320);
			this.tabPageReceita.TabIndex = 0;
			this.tabPageReceita.Text = "Receita";
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
			this.maskedTextBoxCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private System.Windows.Forms.TabPage tabPageReceita;
		private System.Windows.Forms.Button buttonSearchCNPJInfo;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxCNPJ;
		private System.Windows.Forms.Label label1;
	}
}

