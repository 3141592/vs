using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.json.net
{
    public class Product
    {
        public string name { get; set; }
        public int sku { get; set; }
        public double salePrice { get; set; }
    }

    public class RootObject
    {
        public List<Product> products { get; set; }
    }
}
