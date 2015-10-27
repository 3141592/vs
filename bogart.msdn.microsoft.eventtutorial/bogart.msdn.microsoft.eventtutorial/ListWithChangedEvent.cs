using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://msdn.microsoft.com/en-us/library/aa645739%28v=vs.71%29.aspx
namespace gunter.roy.msdn.microsoft.eventtutorial
{
    // A delegate type for hooking up change notifications.
    public delegate void ChangedEventHandler(object sender, EventArgs e);

    // A class that works just like ArrayList, but sends event
    // notifications whenever the list changes.
    public class ListWithChangedEvent : ArrayList
    {
        //An event that clients use to be notified when the list changes.
        public event ChangedEventHandler Changed;
        public event ChangedEventHandler Changed2;

        // Invoke the Changed event 
        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        protected virtual void OnChanged2(EventArgs e)
        {
            if (Changed2 != null)
                Changed2(this, e);
        }

        public override int Add(object value)
        {
            int i = base.Add(value);
            OnChanged(EventArgs.Empty);
            OnChanged2(EventArgs.Empty);
            return i;
        }

        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }

        public int GetInvocationListLength()
        {
            int d = 0;

            if (this.Changed != null)
            {
                d = this.Changed.GetInvocationList().Length; //Delegate[]
            }

            if (this.Changed2 != null)
            {
                d = this.Changed2.GetInvocationList().Length; //Delegate[]
            }

            return d;
        }

        public int GetInvocationListLength2()
        {
            var d = this.Changed2.GetInvocationList(); //Delegate[]
            return d.Length;
        }

        protected void RemoveOneInvocation()
        {
            Delegate[] delegates = this.Changed2.GetInvocationList();
            for(int i = 0; i < delegates.Length; i++)
            {
                Console.WriteLine("Delegate method: {0}", delegates[i].Method.ToString());
                if (i == delegates.Length)
                {
                    
                }
            }
        }
    }

    public class List2 : ListWithChangedEvent
    {
        protected override void OnChanged2(EventArgs e)
        {
            Console.WriteLine("Called from child class.");

            if (GetInvocationListLength2() > 1)
            {
                Console.WriteLine("Removing one invocation.");
                RemoveOneInvocation();
            }

            base.OnChanged2(e);
        }
    }
}
