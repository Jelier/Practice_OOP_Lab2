using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Encapsulation***");
            Employee emp = new Employee("Marvin", 18, 456, 30000, "322322");
            Employee joe = new Employee();
            joe.Age++;
            emp.GiveBonus(1000);
            emp.DisplayStats();

            emp.Name = "Marv";
            Console.WriteLine("Emp is named: {0}", emp.Name);
            Console.ReadLine();
        }
    }
}
