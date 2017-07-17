using Controller;
using System;
using System.Windows.Forms;

namespace View
{
	public partial class Interface : MetroFramework.Forms.MetroForm
	{
		ReceitaController receitaController;

		public Interface()
		{
			InitializeComponent();
			receitaController = new ReceitaController();
		}

		private void buttonSearchCNPJInfo_Click(object sender, EventArgs e)
		{
			string cnpj = maskedTextBoxCNPJ.Text;
			Model.Receita.ReceitaModel model = receitaController.GetCNPJInfo(cnpj);
		}
	}
}
