using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
  class Program
  {
    public void MainFunction()
    {
      Console.WriteLine("Main Class");
    }
    static void Main(string[] args)
    {
      Program obj = new Program();
      obj.MainFunction();

      demo dObj = new demo();
      dObj.addition();
    }
  }

  class demo
  {
    int x = 10;
    int y = 20;
    int z;

    public void addition()
    {
      z = x + y;
      Console.WriteLine("Other class in Namespace");
      Console.WriteLine(z);
    }
  }
}
