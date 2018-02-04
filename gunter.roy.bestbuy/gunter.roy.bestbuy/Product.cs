using System;
using System.Collections;
using System.Collections.Generic;


namespace gunter.roy.bestbuy
{
    /*
        Full request URL for products:
        http://api.bestbuy.com/v1/products%28search=laptop%29?show=accessories.sku,color,description,details.name,sku&format=json&pageSize=15&page=5&apiKey=YourAPIKey

        Parts:
            URL:           http://api.bestbuy.com/v1/
            category:      products
            search string: %28search=laptop%29 OR (search=laptop)
            show:          ?show=accessories.sku,color,description,details.name,sku [any of the Fields]
            format:        &format=json
            pageSize:      &pageSize=15
            page:          &page=5
            api key:       &apiKey=YourAPIKey
    */

    public class Product
    {
        public static string Category = "products";

        // Created this using http://json2csharp.com/
        public static string[] Fields =
        {
            "accessories.sku",
            "color",
            "condition",
            "customerReviewAverage",
            "customerReviewCount",
            "customerTopRated",
            "depth",
            "description",
            "details.name",
            "details.value",
            "digital",
            "features.feature",
            "format",
            "frequentlyPurchasedWith.sku",
            "height",
            "includedItemList.includedItem",
            "longDescription",
            "longDescriptionHtml",
            "manufacturer",
            "modelNumber",
            "name",
            "preowned",
            "quantityLimit",
            "relatedProducts.sku",
            "releaseDate",
            "shortDescription",
            "shortDescriptionHtml",
            "sku",
            "upc",
            "warrantyLabor",
            "warrantyParts",
            "weight",
            "width" };

        public string name { get; set; }
        public int sku { get; set; }
        public double salePrice { get; set; }
        public List<Accessory> accessories { get; set; }
        public string color { get; set; }
        public string condition { get; set; }
        public string customerReviewAverage { get; set; }
        public int? customerReviewCount { get; set; }
        public bool customerTopRated { get; set; }
        public string depth { get; set; }
        public object description { get; set; }
        public List<Detail> details { get; set; }
        public bool digital { get; set; }
        public List<Feature> features { get; set; }
        public object format { get; set; }
        public List<object> frequentlyPurchasedWith { get; set; }
        public string height { get; set; }
        public List<IncludedItemList> includedItemList { get; set; }
        public string longDescription { get; set; }
        public string longDescriptionHtml { get; set; }
        public string manufacturer { get; set; }
        public string modelNumber { get; set; }
        public bool preowned { get; set; }
        public int? quantityLimit { get; set; }
        public List<RelatedProduct> relatedProducts { get; set; }
        public string releaseDate { get; set; }
        public string shortDescription { get; set; }
        public string shortDescriptionHtml { get; set; }
        public string upc { get; set; }
        public string warrantyLabor { get; set; }
        public string warrantyParts { get; set; }
        public string weight { get; set; }
        public string width { get; set; }

        public override string ToString()
        {
            return name + ", " + sku + ", " + salePrice;
        }
    }

    public class ProductList
    {
        public List<Product> products { get; set; }

        public string QueryString(ArrayList searchTerms = null, 
                                         ArrayList fields = null, 
                                         int pageSize = 10, 
                                         int page = 1)
        {
            string queryString = string.Empty;

            queryString = "products?name[$like]=*" + searchTerms + "*";

            return queryString;
        }

        private string CreateSearchTermString(ArrayList searchTerms)
        {
            string searchTermString = string.Empty;

            foreach (string term in searchTerms)
            {
                if (searchTerms.IndexOf(term) == searchTerms.Count - 1)
                {
                    searchTermString = searchTermString + "name[$like]=" + term;
                }
                else
                {
                    searchTermString = searchTermString + "name[$like]=" + term + "&";
                }
            }

            return searchTermString;
        }

        private string CreateShowTermString(ArrayList fields)
        {
            string showString = "? $select[]=";

            foreach (string field in fields)
            {
                if (fields.IndexOf(field) == fields.Count - 1)
                {
                    showString = showString + field + ",";
                }
                else
                {
                    showString = showString + field + "&";
                }
            }

            return showString;
        }

        private string CreatePageTermString()
        {
            string pageString = string.Empty;

            return pageString;
        }

        public string ShowString()
        {
            return "?show=name,sku,salePrice&format=json";
        }
    }

    public class Accessory
    {
        public int sku { get; set; }
    }

    public class Detail
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Feature
    {
        public string feature { get; set; }
    }

    public class IncludedItemList
    {
        public string includedItem { get; set; }
    }

    public class RelatedProduct
    {
        public int sku { get; set; }
    }
}
