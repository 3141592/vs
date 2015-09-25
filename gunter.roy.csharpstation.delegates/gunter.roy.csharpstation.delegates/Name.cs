using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.csharpstation.delegates
{
    public delegate int Comparer(object obj1, object obj2);

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Name(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        // delegate method handler
        public static int CompareFirstNames(object name1, object name2)
        {
            string n1 = ((Name)name1).FirstName;
            string n2 = ((Name)name2).FirstName;

            if(String.Compare(n1,n2) > 0)
            {
                return 1;
            }
            else if (String.Compare(n1,n2) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        // delegate method handler
        public static int CompareLastNames(object name1, object name2)
        {
            string n1 = ((Name)name1).LastName;
            string n2 = ((Name)name2).LastName;

            if (String.Compare(n1, n2) > 0)
            {
                return 1;
            }
            else if (String.Compare(n1, n2) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
