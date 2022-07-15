
using Assingment2.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace Assingment2
{

    internal class Program
    {
        public static List<Coin> coins_data;
        public static List<Coin> traders_data;
     
           

      

            static void Main(string[] args)
        {
            
             coins_data = File.ReadAllLines(@"D:\Assingment2\Data\coins.csv")
                                             .Skip(1)
                                             .Select(x => Coin.GetCoins(x))
                                             .ToList();
             traders_data = File.ReadAllLines(@"D:\Assingment2\Data\traders.csv")
                                             .Skip(1)
                                             .Select(x => Coin.GetCoins(x))
                                             .ToList();
                string json = File.ReadAllText("myobjects.json");
            void Menu_options()
            {
                Console.WriteLine("Menu Bar ");

                Console.WriteLine("1. Coin by name or code" +
                        "\n 2. Get Top 50 coins" +
                        "\n 3. Display Portfolio" +
                        "\n 4. Total Profit" +
                        "\n 5. Voila!");

                //Displayed the menu functionality on Console with 5 options .
            }
            var playerList = JsonConvert.DeserializeObject<List<>>(json);
            }
    }
    
}