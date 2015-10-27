using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunter.roy.msdn.microsoft.anonymousmethods
{
    class Form1 : Form
    {
        public Form1()
        {
            Button helloButton = new Button();
            helloButton.Text = "Hello";

            helloButton.Click +=
                delegate
                {
                    MessageBox.Show("Hello");
                };

            Button goodbyeButton = new Button();
            goodbyeButton.Text = "Goodbye";
            goodbyeButton.Left = helloButton.Width + 5;
            goodbyeButton.Click +=
                delegate (object sender, EventArgs e)
                {
                    string message = (sender as Button).Text;
                    MessageBox.Show(message);
                    Application.Exit();
                };

            Controls.Add(helloButton);
            Controls.Add(goodbyeButton);
        }
    }
}
