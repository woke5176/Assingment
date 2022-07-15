using Assingment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2.Services
{
    public class UpdatePrice
    {
        private double price;
        private Coin coin;
        private TransactionStatus status;

        public UpdatePrice(List<transacted> transact) 
        {
        if (Transaction.coins_symbolised.Contains("coin"))
            this.coin = Transaction.coins_symbolised["coin"];
        
        this.price = (Double) "price");
        this.status = TransactionStatus.IN_PROGRESS;
    }

  


    public double getPrice()
    {
        return price;
    }

  
    public void setPrice(double price)
    {
        this.price = price;
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
