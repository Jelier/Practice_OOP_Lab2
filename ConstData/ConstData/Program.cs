using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14;
        public static readonly double E;
        static MyMathClass()
        {
            E = 2.1;
        }
    }
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ФАН ВИТХ КОНСТ ***");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
            Console.WriteLine("The value of E is: {0}", MyMathClass.E);
            Console.ReadLine();
        }
    }
}
