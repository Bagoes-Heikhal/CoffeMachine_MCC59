using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffemachine
{
    class Coffe
    {
        // Encapsulation
        public String Name { get; set; }
        public int Sugar { get; set; }
        public int Water { get; set; }
        public int Coffee { get; set; }
        public int Price { get; set; }

        // Constructor
        public Coffe(String productName, int sugarNeed, int waterNeed, int coffeNeed, int priceNeed)
        {
            Name = productName;
            Sugar = sugarNeed;
            Water = waterNeed;
            Coffee = coffeNeed;
            Price = priceNeed;
        }

        public Coffe(String Product_Name, int sugarNeed, int waterNeed, int coffeNeed)
        {
            Name = Product_Name;
            Sugar = sugarNeed;
            Water = waterNeed;
            Coffee = coffeNeed;
        }
    }


}
