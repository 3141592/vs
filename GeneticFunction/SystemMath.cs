using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Gunter.Roy.Mathematics.GeneticFunction
{
    public partial class SystemMathHelp : Form
    {
        public SystemMathHelp()
        {
            InitializeComponent();


        }

        private void SystemMathHelp_Load(object sender, EventArgs e)
        {
            try
            {
                string resourceName = "Gunter.Roy.Resources.SystemMath.htm";

                Assembly assembly = Assembly.GetExecutingAssembly();

                TextReader textReader = new StreamReader(assembly.GetManifestResourceStream(resourceName));

                string MathClass = textReader.ReadToEnd();
                this.webBrowser1.DocumentText = MathClass;
                textReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SystemMathHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            webBrowser1.Dispose();
        }

    }
}
