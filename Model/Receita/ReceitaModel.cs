using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model.Receita
{
	[DataContract]
    public class ReceitaModel
    {
		[DataMember]
		public List<AtividadePrincipalModel> atividade_principal { get; set; }

		[DataMember]
		public string data_situacao { get; set; }

		[DataMember]
		public string complemento { get; set; }

		[DataMember]
		public string nome { get; set; }

		[DataMember]
		public string uf { get; set; }

		[DataMember]
		public string telefone { get; set; }

		[DataMember]
		public string email { get; set; }

		[DataMember]
		public List<QsaModel> qsa { get; set; }

		[DataMember]
		public string situacao { get; set; }

		[DataMember]
		public string bairro { get; set; }

		[DataMember]
		public string logradouro { get; set; }

		[DataMember]
		public string numero { get; set; }

		[DataMember]
		public string cep { get; set; }

		[DataMember]
		public string municipio { get; set; }

		[DataMember]
		public string abertura { get; set; }

		[DataMember]
		public string natureza_juridica { get; set; }

		[DataMember]
		public string cnpj { get; set; }

		[DataMember]
		public string ultima_atualizacao { get; set; }

		[DataMember]
		public string status { get; set; }

		[DataMember]
		public string tipo { get; set; }

		[DataMember]
		public string fantasia { get; set; }

		[DataMember]
		public string efr { get; set; }

		[DataMember]
		public string motivo_situacao { get; set; }

		[DataMember]
		public string situacao_especial { get; set; }

		[DataMember]
		public string data_situacao_especial { get; set; }

		[DataMember]
		public List<AtividadeSecundariaModel> atividades_secundarias { get; set; }

		[DataMember]
		public string capital_social { get; set; }

		[DataMember]
		public object extra { get; set; }
	}
}
