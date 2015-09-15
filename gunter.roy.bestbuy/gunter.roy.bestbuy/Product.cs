using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.bestbuy
{
    public class Product
    {
        public string name { get; set; }
        public int sku { get; set; }
        public double salePrice { get; set; }
    }

    public class ProductList
    {
        public List<Product> products { get; set; }
    }
}
