using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gunter.roy.msdn.microsoft.attributes;

namespace gunter.roy.msdn.microsoft.nullabletypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? startDate = null;
            DateTime endDate = DateTime.Now.AddDays(7);

            Console.WriteLine("Start: {0}", startDate);

            startDate = DateTime.Now;
            Console.WriteLine("Start: {0}", startDate);
            Console.WriteLine("End: {0}", endDate);

            endDate = startDate ?? DateTime.Now;
            Console.WriteLine("End: {0}", endDate);

            Console.WriteLine(".Net Framework Version {0}", Environment.Version.ToString());

            Console.ReadKey();
        }
    }
}
