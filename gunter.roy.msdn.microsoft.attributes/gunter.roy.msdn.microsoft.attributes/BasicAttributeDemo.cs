using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.attributes
{
    class BasicAttributeDemo
    {
        [Obsolete]
        public void FirstDeprecated()
        {
            Console.WriteLine("First deprecated method");
        }

        [ObsoleteAttribute]
        public void SecondDeprecated()
        {
            Console.WriteLine("Second deprecated method");
        }

        [Obsolete("You should not use this method")]
        public void ThirdDeprecated()
        {
            Console.WriteLine("Third deprecated method");
        }
    }

    class AttributeParamsDemo
    {
        [DllImport("User32.dll", EntryPoint = "MessageBox")]
        static extern int MessageDialog(int hWnd, string msg, string caption, int msgType);
    }
}
