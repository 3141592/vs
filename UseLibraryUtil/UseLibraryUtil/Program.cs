using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUtil;

namespace UseLibraryUtil
{
  class Program
  {
    static void Main(string[] args)
    {
      // library class instance
      MathLib obj = new MathLib();

      // method calls
      obj.calculateSum(2, 5);
      obj.calculateSqrt(25);
    }
  }
}
