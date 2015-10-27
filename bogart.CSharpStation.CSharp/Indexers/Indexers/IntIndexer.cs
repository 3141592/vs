using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class IntIndexer
    {
        private string[] myData;

        public IntIndexer(int size)
        {
            myData = new string[size];

            for (int i = 0; i < size; i++)
            {
                myData[i] = "Empty";
            }
        }

        public string this[int pos]
        {
            get
            {
                return myData[pos];
            }
            set
            {
                myData[pos] = value;
            }
        }
    }
}
