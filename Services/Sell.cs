using Assingment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2.Services
{
    public class Sell
    {
        private Coin coin;
        private long quantity;
        private String walletAddress;
        private TransactionStatus status;

       
        public Sell(List<transacted> transact) 
        {
        if (Transaction.coins_symbolised.Contains((String)transact["coin"]
            this.coin = Transaction.symbolWiseCoinMap.get((String)transact["coin"]);
        else
            throw new CoinNotFoundException("Coin not Found for the given Symbol: " + obj.get("coin"));
        this.walletAddress = (String) obj.get("wallet_address");
        this.quantity = (Long) obj.get("quantity");
        this.status = TransactionStatus.IN_PROGRESS;
    }

   
    public TransactionStatus getStatus()
    {
        return status;
    }

    public void setStatus(TransactionStatus status)
    {
        this.status = status;
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
