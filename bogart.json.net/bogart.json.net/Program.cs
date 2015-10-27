using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace gunter.roy.json.net
{
    class Program
    {
        // Try https://github.com/restsharp/RestSharp

        static void Main(string[] args)
        {
            string json = @"{
                'Email': 'james@example.com',
                'Active': true,
                'CreatedDate': '2013-01-20T00:00:00Z',
                'Roles': [
                  'User',
                 'Admin'
                ]
             }";

            string json2 = @"{
              'name': 'Dell - 14 Refurbished Laptop - Intel Core i5 - 4GB Memory - 320GB Hard Drive - Black',
              'sku': 9282219,
              'salePrice': 319.99
            }";

            string json3 = @"
                {
                 'products': [
                    {
                      'name': 'Dell - 14\' Refurbished Laptop - Intel Core i5 - 4GB Memory - 320GB Hard Drive - Black',
                      'sku': 9282219,
                      'salePrice': 319.99
                    },
                    {
                      'name': 'Dell - 14\' Refurbished Laptop - Intel Core i5 - 4GB Memory - 320GB Hard Drive - Black',
                      'sku': 9283708,
                      'salePrice': 334.99
                    },
                    {
                      'name': 'Dell - 14\' Refurbished Laptop - Intel Core i5 - 4GB Memory - 500GB Hard Drive - Black',
                      'sku': 9282026,
                      'salePrice': 364.99
                    },
                    {
                      'name': 'Dell - 14\' Refurbished Laptop - Intel Core i5 - 4GB Memory - 500GB Hard Drive - Black',
                      'sku': 9282104,
                      'salePrice': 344.99
                    },
                    {
                      'name': 'Dell - 14\' Refurbished Laptop - Intel Core i5 - 8GB Memory - 500GB Hard Drive - Black',
                      'sku': 9283699,
                      'salePrice': 419.99
                    },
                    {
                      'name': 'Dell - 14\' Refurbished Laptop - Intel Core i5 - 8GB Memory - 500GB Hard Drive - Black',
                      'sku': 9283437,
                      'salePrice': 434.99
                    },
                    {
                      'name': 'Dell - 14.1\' Refurbished Laptop - Intel Core2 Duo - 2GB Memory - 160GB Hard Drive - Black',
                      'sku': 5279001,
                      'salePrice': 209.99
                    },
                    {
                      'name': 'Dell - 2-in-1 13.3\' Touch-Screen Laptop - Intel Core i5 - 8GB Memory - 500GB Hard Drive - Silver Touch',
                      'sku': 9522157,
                      'salePrice': 749.99
                    },
                    {
                      'name': 'Dell - 2-in-1 13.3\' Touch-Screen Laptop - Intel Core i7 - 8GB Memory - 1TB Hard Drive - Silver Touch',
                      'sku': 9514008,
                      'salePrice': 849.99
                    },
                    {
                      'name': 'Dell - Inspiron 11.6\' Touch-Screen Laptop - Intel Celeron - 4GB Memory - 500GB Hard Drive - Silver',
                      'sku': 9568018,
                      'salePrice': 399.99
                    }
                  ]
                }
            ";
              
            Account account = JsonConvert.DeserializeObject<Account>(json);

            Product product = JsonConvert.DeserializeObject<Product>(json2);

            RootObject productList = JsonConvert.DeserializeObject<RootObject>(json3);

            Console.WriteLine(account.Email);
        }
    }
}
