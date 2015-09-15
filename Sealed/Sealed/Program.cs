using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunter.Roy.CSharpCorner.Oop
{
  class Program
  {
    static void Main(string[] args)
    {
      Sealed SealedInstance = new Sealed();
      SealedInstance.MyFunction();
    }
  }
}
