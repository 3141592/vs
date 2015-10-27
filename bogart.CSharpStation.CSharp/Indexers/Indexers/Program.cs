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
            string value = "No value!";

            DoIntInedxer(size);
            DoOverloadedIndexer(size, value);
        }

        static void DoIntInedxer(int size)
        {
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

        static void DoOverloadedIndexer(int size, string value)
        {
            OverloadedIndexer myIndex = new OverloadedIndexer(size);

            myIndex[9] = "Some vallue";
            myIndex[3] = "Another value";
            myIndex[5] = "Any Value";

            myIndex["Empty"] = value;

            Console.WriteLine("\nOverloadedIndexer Output\n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("myIndex[{0}]: {1}", i, myIndex[i]);
            }
            Console.WriteLine(myIndex[value]);
            Console.ReadKey();
        }
    }
}
