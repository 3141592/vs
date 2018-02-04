using System;
using System.Collections;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace gunter.roy.bestbuy
{
    public class BestBuyAPI
    {
        public static string UrlRequest = string.Empty;
        public static ProductList Products = new ProductList();

        // Full url is:
        // http://api.bestbuy.com/v1/products((search=touchscreen&search=apple)?show=name,sku,salePrice&format=json&apiKey=YourAPIKey
        //private static string url = "http://api.bestbuy.com/v1/";
        private static string url = "http://localhost:3030/";

        public static void ProductRequest(string queryString, string showString)
        {
            try
            {
                UrlRequest = url + queryString + showString;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(UrlRequest);
                ((HttpWebRequest)request).UserAgent = ".NET Framework Example Client";
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                Products = JsonConvert.DeserializeObject<ProductList>(responseFromServer);

                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
