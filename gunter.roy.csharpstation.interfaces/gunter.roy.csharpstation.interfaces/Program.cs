using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.csharpstation.interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceImplmenter ii = new InterfaceImplmenter();
            ii.MethodToImplement();
            ii.ParentInterfaceMethod();
            Console.ReadKey();
        }
    }
}
