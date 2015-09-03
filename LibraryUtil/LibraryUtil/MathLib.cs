using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunter.Roy.CSharpCorner.Oop
{
  public class MathLib
  {
    // constructor
    public MathLib()
    {
      Console.WriteLine("Constructing...");
    }

    //destructor
    ~MathLib()
    {
      Console.WriteLine("About to call Dispose...");
      Dispose();
    }
    
    public void Dispose()
    {
      Console.WriteLine("Starting Dispose...");
    }

    public void calculateSum(int x, int y)
    {
      int z = x + y;
      Console.WriteLine(z);
    }

    public void calculateSqrt(double x)
    {
      double z = Math.Sqrt(x);
      Console.WriteLine(z);
    }

   }
}
