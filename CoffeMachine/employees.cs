using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffemachine
{
    class Employees
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary  { get; set; }

        public Employees(string id, string name, int age, int salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public virtual void Introduction()
        {
            Console.Clear();
            Console.WriteLine("Hello");
            Console.WriteLine($"my name is {Name}");
            Console.WriteLine("Is there Anything that i can help?");
        }

    }

    class Managger : Employees
    {
        public Managger(string id, string name, int age, int salary)
               :base(id, name, age, salary)
        {
        }
        public override void Introduction()
        {
            base.Introduction();
            Console.WriteLine("im the managger here");
        }
    }
}
