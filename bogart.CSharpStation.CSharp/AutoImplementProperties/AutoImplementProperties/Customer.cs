using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementProperties
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private string SSN { get; }

        public Customer(int id, string name, string ssn)
        {
            ID = id;
            Name = name;
            SSN = ssn;
        }
    }
}
