using Assingment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2.Services
{
    public class AddVol
    {
        private long volume;
        private Coin coin;
        private TransactionStatus status;

        /**
         * @param obj Require a transaction JSONObject to parse and set all the data of the AddVolume like Coin and quantity.
         * @throws CoinNotFoundException When coin is not present on which addVolume transaction will be done.
         */
        public AddVol()
        {

            if (Transaction.coins_symbolised.Contains("coin"))
                this.coin = Transaction.coins_symbolised["coins"];


        }

     


        public long getVolume()
        {
            return volume;
        }


        public void setVolume(long volume)
        {
            this.volume = volume;
        }


        public Coin getCoin()
        {
            return coin;
        }

        public void setCoin(Coin coin)
        {
            this.coin = coin;
        }



    }
}
