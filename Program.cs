
using Assingment2.Models;

namespace Assingment2
{

    internal class Program
    {
        public static List<Coin> coins_data;
        public static List<Coin> traders_data;

        static void Main(string[] args)
        {
            // MainMenu : 
             coins_data = File.ReadAllLines(@"D:\Assingment2\Data\coins.csv")
                                             .Skip(1)
                                             .Select(x => Coin.GetCoins(x))
                                             .ToList();
             traders_data = File.ReadAllLines(@"D:\Assingment2\Data\traders.csv")
                                             .Skip(1)
                                             .Select(x => Coin.GetCoins(x))
                                             .ToList();

          
        }
    }
    
}