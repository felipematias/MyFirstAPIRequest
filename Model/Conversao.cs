using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]

    public class Conversao
    {
        [DataMember]
        public string @base { get; set; }
        [DataMember]
        public string date { get; set; }
        [DataMember]
        public Rates rates { get; set; }
    }
}
