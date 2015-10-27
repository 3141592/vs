using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace gunter.roy.getcredentials
{
    public partial class GetCredentials : Form
    {
        private const string PATH = "D:\\Keys\\keys.csv";

        public GetCredentials()
        {
            InitializeComponent();
        }

        private void _selectButton_Click(object sender, EventArgs e)
        {

        }

        private void GetCredentials_Load(object sender, EventArgs e)
        {
            // Pull credentials from local store
            // Format is:
            // CredentialName, UserName, Key

            // Parse values
            using (TextFieldParser parser = new TextFieldParser(PATH))
            {
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    this._credentialsComboBox.Items.Add(new Credential()
                    {
                        CredentialName = fields[0],
                        UserName = fields[1],
                        Key = fields[2]
                    });
                }
            }

        }
    }
}
