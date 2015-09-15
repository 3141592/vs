using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunter.roy.wikipedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sURL;
            sURL = "http://microsoft.com";

            HttpWebRequest myHttpWebRequest;
            myHttpWebRequest = (HttpWebRequest)WebRequest.Create(sURL);
            myHttpWebRequest.UserAgent = "leviticus2195 Test Client";
            
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Stream streamResponse = myHttpWebResponse.GetResponseStream();
            StreamReader streamRead = new StreamReader(streamResponse);
            Char[] readBuff = new Char[256];
            int count = streamRead.Read(readBuff, 0, 256);
            string content = "";
            while (count > 0)
            {
                String outputData = new String(readBuff, 0, count);
                content = content + outputData;
                count = streamRead.Read(readBuff, 0, 256);
            }
            // Release the response object resources.
            streamRead.Close();
            streamResponse.Close();
            myHttpWebResponse.Close();
            this.richTextBox1.AppendText(content);
        }
    }
}
