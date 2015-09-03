using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunter.Roy.CSharpCorner.Oop
{
  class Program
  {
    public string name;

    public void setName(string last)
    {
      name = last;
    }

    public void setName(string first, string last)
    {
      name = first + " " + last;
    }

    public void setName(string first, string middle, string last)
    {
      name = first + " " + middle + " " + last;
    }

    static void Main(string[] args)
    {
        Program obj = new Program();

        obj.setName("barack");
        obj.setName("barack ", " obama ");
        obj.setName("barack ", "hussian", "obama");
      Console.WriteLine(obj.name);
     }
  }
}
