using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunter.Roy.CSharpCorner.Oop
{
  class MyBase
  {
    public virtual void VirtualMethod()
    {
      Console.WriteLine("Virtual method defined in MyBase");
    }

    public void HideMe()
    {
      Console.WriteLine("MyBase Hide me");
    }
  }

  class MyDerived : MyBase
  {
    public override void VirtualMethod()
    {
      Console.WriteLine("Virtual method defined in derived class");
    }

    public void HideMe()
    {
      Console.WriteLine("MyDerived Hide me");
    }
  }
}
