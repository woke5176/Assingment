using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2.Models
{
    internal class Trader
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Wallet_Address { get; set; }



        public static Trader GetTraders(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Trader trader = new Trader();

            trader.FirstName = (values[1]);
            trader.LastName = values[2];
            trader.Phone = values[3];
            trader.Wallet_Address = (values[4]);

            return trader;
        }
    }
}

