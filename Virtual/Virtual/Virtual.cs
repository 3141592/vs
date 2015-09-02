using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{

  class myBase
  {
    public virtual void VirtualMethod()
    {
      Console.WriteLine("Virtual method defined in myBase");
    }
  }

  class myDerived : myBase
  {
    public override void VirtualMethod()
    {
      Console.WriteLine("Virtual method defined in derived class");
    }
  }
}
