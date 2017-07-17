using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model.Receita
{
	[DataContract]
	public class AtividadeSecundariaModel
	{
		[DataMember]
		public string code { get; set; }

		[DataMember]
		public string text { get; set; }
	}
}
