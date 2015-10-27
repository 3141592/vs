using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementProperties
{
    class AutoImplementedCustomerManager
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer(1,"Joe Biden","555-55-5555");

            cust.ID = 1;
            cust.Name = "J Biden";

            Console.WriteLine(
                "ID: {0}, Name: {1}",
                cust.ID,
                cust.Name);

            Console.ReadKey();
        }
    }
}
