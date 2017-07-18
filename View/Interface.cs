using Controller;
using System;
using System.Windows.Forms;

namespace View
{
	public partial class Interface : MetroFramework.Forms.MetroForm
	{
		ReceitaController receitaController;
        RatesController ratesController;


        public Interface()
		{
			InitializeComponent();
			receitaController = new ReceitaController();
            ratesController = new RatesController();
		}

		private void buttonSearchCNPJInfo_Click(object sender, EventArgs e)
		{
            // 18240617000140
            // 16501555000157
			string cnpj = maskedTextBoxCNPJ.Text;
			Model.Receita.ReceitaModel model = receitaController.GetCNPJInfo(cnpj);
            cnpjsituation.Text = model.situacao;
            cnpjtelephone.Text = model.telefone;
            emailcnpj.Text = model.email;
            tbNameCNPJ.Text = model.nome;

            dgvPartners.DataSource = model.qsa;

        }

        private void tabPageReceita_Click(object sender, EventArgs e)
        {

        }

        private void emailcnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void ButtonSearchCurrency_Click(object sender, EventArgs e)
        {
            string currency = BoxCurrencyValue.Text;
            Model.Conversao model = ratesController.GetCurrencyInfo(currency);
            textBoxUSD.Text = model.rates.USD.ToString();
            textBoxCAD.Text = model.rates.CAD.ToString();
        }

        private void cnpjtelephone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
