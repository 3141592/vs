﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
  class Program
  {
    static void Main(string[] args)
    {
      Child cObj = new Child();
      cObj.FatherMethod();
      cObj.ChildMethod();
      Console.ReadKey();
    }
  }
}
