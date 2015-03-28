using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyWebService
{
    class Program
    {
        static void Main(string[] args)
        {

            CurrencyUSD cur = CurrencyWebService.getCurrencyJson("http://devel.farebookings.com/api/curconversor/EUR/USD/75/json");

            Console.WriteLine(cur.USD);
            Console.ReadLine();
        }
    }
}
