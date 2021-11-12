using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffemachine
{
    class Program
    {

        public static void Main(string[] args)
        {

    
            Console.WriteLine("===================================================================");
            Console.WriteLine("Welcome to the coffe shop");
            bool start = true;
            while (start)
            {
                Menu.ActionChoose();
                Console.Write("Choose your action : ");
                int action = NumInput();
                // pakai switch case
                // jangan pakai banyak class
                switch (action)
                {
                    case 1:
                        Menu.ShowMenu();
                        CoffeMachine.CoffeMaker();
                        break;
                    case 2:
                        Console.Clear();
                        Ingridients.ResourcesLeft();
                        break;
                    case 3:
                        EmplooyeeData.TalkToEmployee();
                        break;
                    case 4:
                        start = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }
                Console.WriteLine("===================================================================");
            }

        }

        public static int NumInput()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please Enter a number !! " + e);
            }
            return a;
        }
    }

}
