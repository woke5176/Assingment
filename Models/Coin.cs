using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2.Models
{
    public class Coin
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double Price { get; set; }
        public double CirculatingSupply { get; set; }

        public static Coin GetCoins(string csvLine )
        {
            string[] values = csvLine.Split(',');
            Coin coins = new Coin();

            coins.Rank = Convert.ToInt32(values[1]);
            coins.Name = values[2];
            coins.Symbol = values[3];
            coins.Price = Convert.ToDouble(values[4]);
            coins.CirculatingSupply = Convert.ToInt64(values[5]);

            return coins;
        }
    
    }
}
