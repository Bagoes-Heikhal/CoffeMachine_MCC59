using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffemachine
{
    class Ingridients
    {
        public static Coffe BlackCoffe = new Coffe("BlackCoffe", 1, 2, 3, 10);
        public static Coffe SweetCoffe = new Coffe("SweetCoffe", 1, 2, 2, 5);

        public static Dictionary<string, int> resouces = new()
        {
            { "Sugar", 4 },
            { "Water", 5 },
            { "Coffe", 10 }
        };

        public static IDictionary<string, int> GetProducts(int choose)
        {
            
            
            int sugar = 0; int water = 0; int coffe = 0;

            if (choose == 1)
            {
                sugar = BlackCoffe.Sugar; water = BlackCoffe.Water; coffe = BlackCoffe.Coffee;
            }
            else if (choose == 2)
            {
                sugar = SweetCoffe.Sugar; water = SweetCoffe.Water; coffe = SweetCoffe.Coffee;
            }
            else
            {
                Console.WriteLine("please try again");
            }

            return new Dictionary<string, int>
            {
                    {"Sugar", sugar},
                    {"Water", water},
                    {"Coffe", coffe}
                };
        }

        public static void ResourcesLeft()
        {
            foreach (var pair in resouces)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }

        public static bool ResourcesCheck(int kopi)
        {
            bool ingri_available = true;
            foreach (var pair in GetProducts(kopi))
            {
                int ingri_check = resouces[pair.Key] - GetProducts(kopi)[pair.Key];
                if (ingri_check < 0)
                {
                    ingri_available = false;
                    Console.WriteLine("The resouce is not sufficient");
                }
            }

            return ingri_available;
        }
    }
}
