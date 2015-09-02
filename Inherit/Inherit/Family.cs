using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
  class Family
  {
  }

  public class Father
  {
    //constructor
    public Father()
    {
      Console.WriteLine("Father constructor");
    }

    public void FatherMethod()
    {
      Console.WriteLine("Father method");
    }
  }

  public class Child : Father
  {
    public Child()
      :base()
    {
      Console.WriteLine("Child constructor");
    }
    public void ChildMethod()
    {
      Console.WriteLine("Child method");
    }

  }
}
