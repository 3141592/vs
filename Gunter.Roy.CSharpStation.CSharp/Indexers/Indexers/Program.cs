using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

            IntIndexer myIndex = new IntIndexer(size);

            myIndex[9] = "Some vallue";
            myIndex[3] = "Another value";
            myIndex[5] = "Any Value";

            Console.WriteLine("\nIndexer Output\n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("myIndex[{0}]: {1}", i, myIndex[i]);
            }
            Console.ReadKey();
        }
    }
}
