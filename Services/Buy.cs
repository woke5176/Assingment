using Assingment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2.Services
{
    public class Buy
    {
        private Coin coin;
        private long quantity;
        private String walletAddress;
        private TransactionStatus status;

        /**
         * @param obj Require a transaction JSONObject to parse and
         *            set all the data of the Buy like Coin, quantity and walletAddress.
         * @throws CoinNotFoundException When coin is not present on which Buy transaction will be done.
         */
        public Buy()
        {
            if (Transaction.coins_symbolised.Contains("coin");
            this.coin = Transaction.coins_symbolised["coin"];

            this.walletAddress = Transactionstyle["wallet_address"];
            this.quantity = (long)Transactionstyle"quantity"];
            this.status = TransactionStatus.IN_PROGRESS;
        }

   


        public Coin getCoin()
        {
            return coin;
        }


        public void setCoin(Coin coin)
        {
            this.coin = coin;
        }

        public long getQuantity()
        {
            return quantity;
        }

        public void setQuantity(long quantity)
        {
            this.quantity = quantity;
        }


        public String getWalletAddress()
        {
            return walletAddress;
        }

        public void setWalletAddress(String walletAddress)
        {
            this.walletAddress = walletAddress;

        }
    }
}
