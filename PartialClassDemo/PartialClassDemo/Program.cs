using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      //partial class instance
      partialClassDemo obj = new partialClassDemo();
      obj.method1();
      obj.method2();
    }
  }
}
