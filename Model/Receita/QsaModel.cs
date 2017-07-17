using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model.Receita
{
	[DataContract]
	public class QsaModel
	{
		[DataMember]
		public string qual { get; set; }

		[DataMember]
		public string nome { get; set; }
	}
}
