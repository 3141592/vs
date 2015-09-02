using System;
namespace CustomerOne
{
  class customer
  {
    // Member Vars
    private static int x;

    // Constructor for static initializing fields
    static customer()
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
