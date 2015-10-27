using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunter.Roy.CSharpCorner.Oop
{
  class HRDepartment : Employee
  {
    public override void LeaderName()
    {
      Console.WriteLine("HR Department Leader");
      Console.ReadKey();
    }
  }
}
