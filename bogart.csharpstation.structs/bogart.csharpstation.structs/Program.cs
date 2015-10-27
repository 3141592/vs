using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.csharpstation.structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Height = 10;
            rect.Width = 20;
            Console.WriteLine(string.Format("The area is {0}!", rect.Area()));
            Console.ReadKey();

            Rectangle rect2 = new Rectangle
            {
                Width = 30,
                Height = 3
            };
            Console.WriteLine(string.Format("The area is {0}!", rect2.Area()));
            Console.ReadKey();
        }
    }
}
