using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Automatic Propherties\n");

            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";

            Console.WriteLine("Your car is named {0}? That's odd... ", c.PetName);
            c.DisplayStats();
            Console.ReadLine();
        }
    }
}
