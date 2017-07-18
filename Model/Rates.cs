using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
    
{
    [DataContract]
    public class Rates
    {
        [DataMember]
        public double AUD { get; set; }
        [DataMember]
        public double BGN { get; set; }
        [DataMember]
        public double CAD { get; set; }
        [DataMember]
        public double CHF { get; set; }
        [DataMember]
        public double CNY { get; set; }
        [DataMember]
        public double CZK { get; set; }
        [DataMember]
        public double DKK { get; set; }
        [DataMember]
        public double GBP { get; set; }
        [DataMember]
        public double HKD { get; set; }
        [DataMember]
        public double HRK { get; set; }
        [DataMember]
        public double HUF { get; set; }
        [DataMember]
        public double IDR { get; set; }
        [DataMember]
        public double ILS { get; set; }
        [DataMember]
        public double INR { get; set; }
        [DataMember]
        public double JPY { get; set; }
        [DataMember]
        public double KRW { get; set; }
        [DataMember]
        public double MXN { get; set; }
        [DataMember]
        public double MYR { get; set; }
        [DataMember]
        public double NOK { get; set; }
        [DataMember]
        public double NZD { get; set; }
        [DataMember]
        public double PHP { get; set; }
        [DataMember]
        public double PLN { get; set; }
        [DataMember]
        public double RON { get; set; }
        [DataMember]
        public double RUB { get; set; }
        [DataMember]
        public double SEK { get; set; }
        [DataMember]
        public double SGD { get; set; }
        [DataMember]
        public double THB { get; set; }
        [DataMember]
        public double TRY { get; set; }
        [DataMember]
        public double USD { get; set; }
        [DataMember]
        public double ZAR { get; set; }
        [DataMember]
        public double EUR { get; set; }
    }

}
