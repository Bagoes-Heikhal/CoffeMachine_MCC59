using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffemachine
{
    class Menu
    {
       public static void ActionChoose()
        {
            Console.WriteLine("Action : ");
            Console.WriteLine("1. Buy Coffe");
            Console.WriteLine("2. Check Ingridients");
            Console.WriteLine("3. Talk");
            Console.WriteLine("4. Off");
        }

        public static Dictionary<string, int> MenuAvailable = new()
        {
            { Ingridients.BlackCoffe.Name, Ingridients.BlackCoffe.Price},
            { Ingridients.SweetCoffe.Name, Ingridients.SweetCoffe.Price},
        };

        public static void ShowMenu()
        {
            Console.WriteLine("This is our coffe menu : ");
            int i = 0;
            foreach (var item in MenuAvailable)
            {
                ++i;
                Console.WriteLine($"{i} {item.Key} for {item.Value} $");
            }
        }

        
    }
}
