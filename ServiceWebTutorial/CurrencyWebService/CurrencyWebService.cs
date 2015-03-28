using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyWebService
{
    public static class CurrencyWebService
    {
        public static CurrencyUSD getCurrencyJson(string url)
        {
            try
            {
                //Sincronizacion
                WebClient syncClient = new WebClient();
                var content = syncClient.DownloadString(url);

                //JSON serializador + parseador
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(CurrencyUSD));
                using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(content)))
                {
                    CurrencyUSD currency = (CurrencyUSD)serializer.ReadObject(memoryStream);
                    return currency;
                }
            }
            catch(WebException ex)
            {
                return null;
            }           
        }
    }
}