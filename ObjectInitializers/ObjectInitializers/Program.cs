using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Ща бы с точками пофаниться**");
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();
            Point finalPoint = new Point { X = 30, Y = 30};
            finalPoint.DisplayStats();
            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
            myRect.DisplayStats();
            Console.ReadLine();
        }
    }
}
