using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
  class staticDemo
  {
    // static field
    static int x = 10, y;

    // static method
    static void calculate()
    {
      y = x * x;
      Console.WriteLine(y);
    }

    static void Main(string[] args)
    {
      // function calling directly
      staticDemo.calculate();
    }
  }
}
