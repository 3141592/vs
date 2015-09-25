using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.operatoroverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            MathVector mv1 = new MathVector();
            MathVector mv2 = new MathVector();

            mv1.AddRange(new decimal[] {  1, 3, 6});
            mv2.AddRange(new decimal[] { -5, 3, 8 });

            Console.WriteLine("mv1 + mv2 = {0}", mv1 * mv2);

            MathVector result = mv1 + mv2;
            Console.WriteLine("mv1 * mv2 = {0}", (mv1 + mv2).ToString());

            Console.ReadKey();
        }
    }
}
