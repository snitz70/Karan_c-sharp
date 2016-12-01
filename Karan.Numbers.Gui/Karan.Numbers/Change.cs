using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karan.Numbers
{
    public static class Change
    {
        enum Currency
        {
            TwentyDollar = 2000,
            TenDollar = 1000,
            FiveDollar = 500,
            Dollar = 100,
            Quarter = 25,
            Dime = 10,
            Nickle = 5,
            Penny = 1,
        }

        public static decimal Due(decimal cost, decimal amountTendered)
        {
            return amountTendered - cost;
        }

        public static Dictionary<string, int> DueMonies(decimal changeDue)
        {
            Dictionary<String, int> result = new Dictionary<string, int>();
            int Remainder = (int)(changeDue * 100);
            int Money;

            foreach (var currency in Enum.GetValues(typeof(Currency)).Cast<Currency>().OrderByDescending(x => x))
            {
                Money = Remainder / (int)currency;
                if (Money > 0)
                {
                    Currency value = (Currency)currency;
                    result.Add(value.ToString(), Money);
                    Remainder -= Money * (int)currency;
                }    
            }
            return result;
        }
    }
}
