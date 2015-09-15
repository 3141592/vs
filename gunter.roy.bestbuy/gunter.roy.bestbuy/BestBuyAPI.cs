using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace gunter.roy.bestbuy
{
    public partial class BestBuyAPI : Form
    {
        private const string PATH = "D:\\Keys\\keys.csv";
        private Credential _best_buy_api_key = new Credential();
        private string _credentialName;
        private string _userName;
        private string _key;

        private string _queryString;
        private string _showString = "?show=name,sku,salePrice&format=json";

        public BestBuyAPI()
        {
            InitializeComponent();
        }

        private void BestBuyAPI_Load(object sender, EventArgs e)
        {
            // Pull credentials from local store
            // Format is:
            // CredentialName, UserName, Key

            try
            {
                // Parse values
                using (TextFieldParser parser = new TextFieldParser(PATH))
                {
                    parser.Delimiters = new string[] { "," };

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        _credentialName = fields[0];
                        _userName = fields[1];
                        _key = fields[2];

                        if (_credentialName == "Best Buy")
                        {
                            _best_buy_api_key.CredentialName = _credentialName;
                            _best_buy_api_key.UserName = _userName;
                            _best_buy_api_key.Key = _key;
                            break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                _resultsListBox.Items.Add(ex.Message);
            }
        }

        private void _exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _getProductsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void _mostViewedButton_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://api.bestbuy.com/beta/products/mostViewed?apiKey=" + _best_buy_api_key.Key + "&format=json";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                ((HttpWebRequest)request).UserAgent = ".NET Framework Example Client";
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();



                _resultsListBox.Items.Add("Add");

                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                _resultsListBox.Items.Add(ex.Message);
            }
        }

        private string CreateBetaRequest(string queryString)
        {
            string UrlRequest = "http://api.bestbuy.com/beta/products/mostViewed?apiKey=" +
                                 queryString +
                                 "&format=json" +
                                 "?apiKey=" + _best_buy_api_key.Key;
            return (UrlRequest);
        }

        private void _searchButton_Click(object sender, EventArgs e)
        {
            string _queryString = CreateProductQueryString();
            string _urlRequest = CreateProductRequest(_queryString);
            CreateProductRequest(_urlRequest);
            SendProductRequest(_urlRequest);
            _resultsListBox.Items.Add(_urlRequest);
        }

        private string CreateProductQueryString()
        {
            // Format of the product qeury string is:
            // products(search=touchscreen&search=apple)

            // combine the selected terms into a query string
            _queryString = "";
            for (int i = 0; i < _searchTermsListBox.Items.Count; i++)
            {
                _queryString = _queryString + "search=" + _searchTermsListBox.Items[i].ToString() + "&";
            }
            char[] _trimChars = { '&', ' ' };
            _queryString = _queryString.TrimEnd(_trimChars);
            _queryString = "products(" + _queryString + ")";
            return _queryString;
        }

        private string CreateProductRequest(string queryString)
        {
            // Full url is:
            // http://api.bestbuy.com/v1/products((search=touchscreen&search=apple)?show=name,sku,salePrice&format=json&apiKey=YourAPIKey
            string url = "http://api.bestbuy.com/v1/";
            string urlRequest = url + queryString + _showString + "&apiKey=" + _best_buy_api_key.Key;
            return urlRequest;
        }

        private void SendProductRequest(string urlRequest)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlRequest);
                ((HttpWebRequest)request).UserAgent = ".NET Framework Example Client";
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                var obj = JObject.Parse(responseFromServer);
                ArrayList products = new ArrayList();

                

                foreach (var x in obj)
                {
                    string value = "key: " + x.Key + " value: " + x.Value;
                    if (x.Key == "products")
                    {
                        ParseJsonNet(x);
                        products = ParseJson(x.Value.ToString());
                    }
                }

                CreateProductList(products);

                _resultsListBox.Items.Add(urlRequest);
                _resultsListBox.Items.Add(responseFromServer);

                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                _resultsListBox.Items.Add(ex.Message);
            }
        }

        private void CreateProductList(ArrayList products)
        {
            foreach (string product in products)
            {
                Product newProduct = new Product();
                // STOPPED HERE
            }
        }

        private ArrayList ParseJsonNet(object kvPair)
        {
            ArrayList products = new ArrayList();

            Product product = new Product();
            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(kvPair.ToString());

            return products;
        }

        private ArrayList ParseJson(string value)
        {
            ArrayList products = new ArrayList();
            string[] productArray;

            try
            {
                char[] trimchars = { '[', ']' };
                value = value.Trim(trimchars);
                value = value.Replace("\r", "");
                value = value.Replace("\n", "");
                value = value.Replace("\\", "");

                string[] splitParams = { "{","}," };
                productArray = value.Split(splitParams, StringSplitOptions.RemoveEmptyEntries);

                foreach (string product in productArray)
                {
                    if (product.Trim() != "")
                    {
                        products.Add(product);
                    }
                }

                return products;
            }
            catch(Exception ex)
            {
                _resultsListBox.Items.Add(ex.Message);
                return products;
            }
        }

        private void _addSearchTermButton_Click(object sender, EventArgs e)
        {
            if (_searchTermTextBox.Text != "")
            {
                _searchTermsListBox.Items.Add(_searchTermTextBox.Text);
                _searchTermTextBox.Text = "";
            }
        }

        private void _clearSearchTermsButton_Click(object sender, EventArgs e)
        {
            _searchTermsListBox.Items.Clear();
        }

        private void _clearResultsButton_Click(object sender, EventArgs e)
        {
            _resultsListBox.Items.Clear();
        }
    }
}
