using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.genericcollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myInts = new List<int>();
            myInts.AddRange(new int[] { 1, 3, 6, 9 });
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }

            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
            for (int i = 0; i < 3; i++)
            {
                Customer customer = new Customer(i, "Cust" + i);
                customers.Add(customer.ID, customer);
            }

            foreach(KeyValuePair<int, Customer> custKeyValue in customers)
            {
                Console.WriteLine("Customer: {0} {1} {2}", custKeyValue.Key, custKeyValue.Value.ID, custKeyValue.Value.Name);
            }

            Console.ReadKey();
        }
    }
}
