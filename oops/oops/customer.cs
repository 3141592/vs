  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  namespace Gunter.Roy.CSharpCorner.Oop
{
    class Customer
    {
    // Member Vars
    public int CustID;
    public string Name;
    public string Address;

    // constructor
    public Customer()
    {
      CustID = 1001;
      Name = "Tom";
      Address = "USA";
    }

    public Customer(string fname, string lname)
    {
      Name = fname + " " + lname;
    }

    public void AppendData()
    {
      Console.WriteLine(Name);
    }

    // display Customer records
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
      Customer obj = new Customer();

      // method calling
      obj.displayData();

      // fields calling
      Console.WriteLine(obj.CustID);
      Console.WriteLine(obj.Name);
      Console.WriteLine(obj.Address);

      Customer obj2 = new Customer("Barack", "Obama");
      obj2.AppendData();
    }
  }
}
