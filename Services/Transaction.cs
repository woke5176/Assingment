using Assingment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2.Services
{
    internal class Transaction : Thread
    {
        private String transactionId;

        public static Dictionary<string, Coin> coins_symbolised  = new Dictionary<string, Coin>();
      
        public static List<Coin> allCoinList = new List<Coin>();
       
        public static Dictionary<String, Trader> traderMap = new Dictionary<string, Trader>();
  
        public static List<Trader> allTraderList = new List<Trader>();

     
        public String getTransactionId()
        {
            return transactionId;
        }

        public void setTransactionId(String transactionId)
        {
            this.transactionId = transactionId;
        }


        /**
         * Read all the data from the CSV using the CSVReader classes and store the value in the
         * symbolWiseCoinMap, allCoinList, traderMap, and allTraderList
         */
       
    }
}
