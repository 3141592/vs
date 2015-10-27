using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunter.Roy.CSharpStation.CSharp
{
    public class Customer
    {
        private int _id = -1;
        private string _name = string.Empty;
        private string _ssn = string.Empty;

        public Customer(int id, string name, string ssn)
        {
            _id = id;
            _name = name;
            _ssn = ssn;
        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string SSN
        {
            get
            {
                return SSN;
            }
        }
    }
}
