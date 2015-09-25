using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://msdn.microsoft.com/en-us/library/aa645739%28v=vs.71%29.aspx
namespace gunter.roy.msdn.microsoft.eventtutorial
{
    class EventListener
    {
        private ListWithChangedEvent List;

        public EventListener(ListWithChangedEvent list)
        {
            List = list;
            //List.Changed += new ChangedEventHandler(ListChanged);
            List.Changed2 += new ChangedEventHandler(ListChanged);
            List.Changed2 += new ChangedEventHandler(ListChanged);
        }

        private void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is called when the event fires.");
        }

        public void Detach()
        {
            List.Changed -= new ChangedEventHandler(ListChanged);
            List = null;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            //CallFirst();
            CallSecond();
        }

        static void CallFirst()
        {
            ListWithChangedEvent list = new ListWithChangedEvent();
            EventListener listener = new EventListener(list);

            Console.WriteLine("Length of invocation list: {0}.", list.GetInvocationListLength());

            list.Add("item 1");
            list.Clear();
            listener.Detach();

            Console.WriteLine("Length of invocation list: {0}.", list.GetInvocationListLength());

            Console.ReadKey();
        }

        static void CallSecond()
        {
            List2 list = new List2();
            EventListener listener = new EventListener(list);

            Console.WriteLine("Length of invocation list: {0}.", list.GetInvocationListLength());

            list.Add("item 1");
            list.Clear();
            listener.Detach();

            Console.WriteLine("Length of invocation list: {0}.", list.GetInvocationListLength());

            Console.ReadKey();
        }
    }
}
