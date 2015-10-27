using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.type
{
    class Program
    {
        static void Main(string[] args)
        {
            float lengthFloat = 7.53f;

            int lengthInt = (int)lengthFloat;

            double lengthDoouble = lengthInt;

            Console.WriteLine("lengthFloat = {0}", lengthFloat);
            Console.WriteLine("lengthInt = {0}", lengthInt);
            Console.WriteLine("lengthDouble = {0}", lengthDoouble);

            Employee joe = new Employee();
            joe.Name = "Joe";

            Employee bob = new Employee();
            bob.Name = "Bob";

            bob = joe;

            Console.WriteLine();
            Console.WriteLine("Values After Reference Assignment:");
            Console.WriteLine("joe = " + joe.Name);
            Console.WriteLine("bob = " + bob.Name);

            joe.Name = "Bobbi Jo";

            Console.WriteLine();
            Console.WriteLine("Values After Changing One Instance:");
            Console.WriteLine("joe = " + joe.Name);
            Console.WriteLine("bob = " + bob.Name);

            Console.ReadKey();
        }
    }
}
