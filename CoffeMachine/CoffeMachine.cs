using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffemachine
{
    class CoffeMachine
    {
        public static void CoffeMaker()
        { 
            Console.Write("Choose your coffe : ");
            int kopi = Program.NumInput();

            Console.Write("Input your money : ");
            int duit = Program.NumInput();

            int coinLeft = Coin.CoinExchange(duit, kopi);

            Console.Clear();
            if (Coin.CoinCheck(coinLeft) == true && Ingridients.ResourcesCheck(kopi) == true)
            {
                MakeCoffe(kopi);
                Console.WriteLine($"here's your exhange: {coinLeft}");
            }
            else
            {
                Console.WriteLine($"money returned : {duit}");
            }
        }

        public static void MakeCoffe(int choose)
        {
            foreach (var item in Ingridients.GetProducts(choose))
            {
                Ingridients.resouces[item.Key] -= Ingridients.GetProducts(choose)[item.Key];
            }
        }
    }
}
