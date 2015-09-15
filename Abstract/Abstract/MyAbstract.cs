using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunter.Roy.CSharpCorner.Oop
{
  public abstract class MyAbstract
  {
    public abstract void DisplayData();
  }

  public class Concrete : MyAbstract
  {
    public override void DisplayData()
    {
      Console.WriteLine("Abstract class method.");
      Console.ReadKey();
    }
  }
}
