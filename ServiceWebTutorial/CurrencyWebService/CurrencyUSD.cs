using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CurrencyWebService
{

    [DataContract]
    public class CurrencyUSD
    {
        public static string ACRONYM = "USD";
        public static string NAME = "United States Dollar";

        [DataMember]
        public double USD { get; set; }
    }

}