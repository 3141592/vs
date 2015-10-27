using System;
using System.Collections;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace gunter.roy.bestbuy
{
    public partial class BestBuyAPIApp : Form
    {
        private Credential _best_buy_api_key = new Credential("Best Buy");

        public BestBuyAPIApp()
        {
            InitializeComponent();
        }

        private void _exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _searchProductsButton_Click(object sender, EventArgs e)
        {
            ArrayList _searchStringArray = CreateProductSearchString();
            ArrayList _fieldArray = new ArrayList();
            ProductList productList = new ProductList();

            string queryString = productList.QueryString(_searchStringArray, _fieldArray);
            string showString = productList.ShowString();
            BestBuyAPI.ProductRequest(queryString, showString);

            if (BestBuyAPI.Products.products != null)
            {
                for (int i = 0; i < BestBuyAPI.Products.products.Count; i++)
                {
                    _resultsListBox.Items.Add(BestBuyAPI.Products.products[i].ToString());
                }
            }
            else
            {
                _resultsListBox.Items.Add("No products found.");
            }
            _requestTextBox.Text = BestBuyAPI.UrlRequest;
        }

        private ArrayList CreateProductSearchString()
        {
            // Put each list box item into an ArrayList
            ArrayList searchStringArray = new ArrayList();
            for (int i = 0; i < _searchTermsListBox.Items.Count; i++)
            {
                searchStringArray.Add(_searchTermsListBox.Items[i].ToString());
            }
            return searchStringArray;
        }

        private void _addSearchTermButton_Click(object sender, EventArgs e)
        {
            if (_searchTermTextBox.Text != "")
            {
                if (_searchTermTextBox.Text.Contains(" "))
                {
                    string[] separator = { " " };
                    string[] terms = _searchTermTextBox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    _searchTermsListBox.Items.AddRange(terms);
                }
                else
                {
                    _searchTermsListBox.Items.Add(_searchTermTextBox.Text);

                }
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

        private void BestBuyAPIApp_Load(object sender, EventArgs e)
        {
            //Populate the Fields for Products
            _fieldsCheckedListBox.Items.AddRange(Product.Fields);
        }
    }
}
