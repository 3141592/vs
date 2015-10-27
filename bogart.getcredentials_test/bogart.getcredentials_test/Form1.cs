using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using gunter.roy.getcredentials;

namespace gunter.roy.getcredentials_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            launchCredentialsThread_Click();
        }

        //private void launchCredentialsThread_Click(object sender, RoutedEventArgs e)
        private void launchCredentialsThread_Click()
        {
            Thread credentialsThread = new Thread(delegate ()
            {
                GetCredentials _credentials = new GetCredentials();
                _credentials.Show();
                System.Threading.Dispatcher.Run();
            });

            credentialsThread.SetApartmentState(ApartmentState.STA); // needs to be STA or throws exception
            credentialsThread.Start();
        }
    }
}
