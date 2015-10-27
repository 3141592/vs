using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class OverloadedIndexer
    {
        private string[] myData;

        public OverloadedIndexer(int size)
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

        public string this[string element]
        {
            get
            {
                int count = 0;

                foreach(string value in myData)
                {
                    if(value == element)
                    {
                        count += 1;
                    }
                }

                return string.Format("Number of \"{0}\" value entries: {1}", element, count);
            }
            set
            {
                for(int i = 0; i < myData.Length; i++)
                {
                    if (myData[i] == element)
                    { 
                        myData[i] = value;
                    }
                }
            }
        }
    }
}
