using System;
using System.Drawing;
using System.Windows.Forms;

namespace gunter.roy.csharpstation.events
{
    // custom delegate
    public delegate void StartDelegate();

    class EventDemo : Form
    {
        // custom Event
        /// <summary>
        /// Occurs when the StartEvent method is called.
        /// </summary>
        public event StartDelegate StartEvent;

        public EventDemo()
        {
            Button clickMe = new Button();

            clickMe.Parent = this;
            clickMe.Text = "Click Me";
            clickMe.Location = new Point(
                (ClientSize.Width - clickMe.Width) / 2,
                (ClientSize.Height - clickMe.Height) / 2);

            // Assign EventHandler delegate to button click event
            clickMe.Click += new EventHandler(OnClickMeClicked);

            // Assign StartEvent delegate to Start event
            StartEvent += new StartDelegate(OnStartEvent);

            // Fire StartEvent
            StartEvent();

            CheckHandlers();
        }

        public void OnClickMeClicked(object sender, EventArgs ea)
        {
            MessageBox.Show("Button clicked!");
        }

        public void OnStartEvent()
        {
            MessageBox.Show("Starting now...");
        }

        static void Main(string[] args)
        {
            Application.Run(new EventDemo());
        }

        private void CheckHandlers()
        {
            if (StartEvent != null)
            {
                Console.WriteLine("Handlers still subscribed:");
                foreach (var handler in StartEvent.GetInvocationList())
                {
                    Console.WriteLine("{0}.{1}", handler.Method.DeclaringType, handler.Method.Name);
                }
            }
        }
    }
}
