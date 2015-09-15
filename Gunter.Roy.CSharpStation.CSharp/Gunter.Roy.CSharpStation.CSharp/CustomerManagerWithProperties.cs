using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunter.Roy.CSharpStation.CSharp
{
    class CustomerManagerWithProperties
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer(1, "Joe Biden", "555-55-5555");

            Console.WriteLine(
                "ID: {0}, Name: {1}",
                cust.ID,
                cust.Name);

            Console.ReadKey();
        }
    }
}
