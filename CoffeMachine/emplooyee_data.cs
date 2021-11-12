using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffemachine
{
    class EmplooyeeData
    {
        public static Managger Cris = new("100", "Cris", 22, 1000);
        public static  Employees Jhon = new("101", "Jhon", 22, 1000);

        public static void jhon_talk()
        {
            Jhon.Introduction();
        }

        public static void cris_talk()
        {
            Cris.Introduction();
        }

        public static void TalkToEmployee()
        {
            Console.WriteLine("Who you want to talk with?");
            Console.WriteLine("1. Jhon (Employee)");
            Console.WriteLine("2. Cris (Manager)");

            int pick = Program.NumInput();

            switch (pick)
            {
                case 1:
                    jhon_talk();
                    break;
                case 2:
                    cris_talk();
                    break;
                default:
                    break;
            }

        }
    }


}

