using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[assembly:CLSCompliant(true)]

namespace gunter.roy.msdn.microsoft.attributes
{
    public class Program
    {
        [DllImport("User32.dll", EntryPoint = "MessageBox")]
        static extern int MessageDialog(int hWnd, string msg, string caption, int msgType);

        [method:CLSCompliant(true)]
        public void NonClsCompliantMethod(uint nclsParam)
        {
            Console.WriteLine("Called NonClsCompliantMethod");
        }

        [method: CLSCompliant(true)]
        public void ClsCompliantMethod(int clsParam)
        {
            Console.WriteLine("Called ClsCompliantMethod");
        }

        [STAThread]
        static void Main(string[] args)
        {
            BasicAttributeDemo attrDemo = new BasicAttributeDemo();

            attrDemo.FirstDeprecated();
            attrDemo.SecondDeprecated();
            attrDemo.ThirdDeprecated();

            MessageDialog(0, "MessageDialog called!", "DllImprt Demo", 0);
        }
    }
}
