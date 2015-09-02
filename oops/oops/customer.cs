  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  namespace oops
  {
    class customer
    {
    // Member Vars
    public int CustID;
    public string Name;
    public string Address;

    // constructor
    public customer()
    {
      CustID = 1001;
      Name = "Tom";
      Address = "USA";
    }

    public customer(string fname, string lname)
    {
      Name = fname + " " + lname;
    }

    public void AppendData()
    {
      Console.WriteLine(Name);
    }

    // display customer records
    public void displayData()
    {
      Console.WriteLine("Customer: " + CustID);
      Console.WriteLine("Name: " + Name);
      Console.WriteLine("Address: " + Address);
    }

    // Code for entry point
    static void Main(string[] args)
    {
      // object instantiation
      customer obj = new customer();

      // method calling
      obj.displayData();

      // fields calling
      Console.WriteLine(obj.CustID);
      Console.WriteLine(obj.Name);
      Console.WriteLine(obj.Address);

      customer obj2 = new customer("Barack", "Obama");
      obj2.AppendData();
    }
  }
}
