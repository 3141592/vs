using System;

namespace Gunter.Roy.CSharpCorner.Oop
{
  class Customer
  {
    // Member Vars
    private static int x;

    // Constructor for static initializing fields
    static Customer()
    {
      Console.WriteLine("Starting static constructor");
      x = 10;   
    }
    static public void getData()
    {
      Console.WriteLine("Starting getData()");
      Console.WriteLine(x);
    }
  }
}
