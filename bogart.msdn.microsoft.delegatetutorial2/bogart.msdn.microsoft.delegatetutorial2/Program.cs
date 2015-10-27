using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.delegatetutorial2
{
    delegate void MyDelegate(string s);

    class Program
    {
        public static void Hello(string s)
        {
            Console.WriteLine("Hello, {0}!", s);
        }

        public static void Goodbye(string s)
        {
            Console.WriteLine("Goodbye, {0}!", s);
        }

        static void Main(string[] args)
        {
            MyDelegate a, b, c, d, e;

            
            a = new MyDelegate(Hello);
            b = new MyDelegate(Goodbye);
            c = a + b;
            d = c - a;
            e = a + b + c + d;

            InvokeDelegate(a, "A");
            InvokeDelegate(b, "B");
            InvokeDelegate(c, "C");
            InvokeDelegate(d, "D");
            InvokeDelegate(e, "E");

            Console.ReadKey();
        }

        static void InvokeDelegate(MyDelegate myDelegate, string s)
        {
            Console.WriteLine("Invoking delegate {0}:", s);
            myDelegate(s);
        }
    }
}
