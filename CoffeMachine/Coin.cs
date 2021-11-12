using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffemachine
{
    static class Coin
    {
        public static int CoinExchange(int money, int coffeChoosen)
        {
            int exchange = money - Menu.MenuAvailable.ElementAt(coffeChoosen - 1).Value;

            return exchange;
        }

        public static bool CoinCheck(int coin)
        {
            bool pay = true;

            if (coin < 0)
            {
                pay = false;
                Console.WriteLine("your money is not sufficient");
            }
            return pay;
        }
    }
}
