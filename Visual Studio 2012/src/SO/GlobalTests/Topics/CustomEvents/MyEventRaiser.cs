using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTests.Topics.CustomEvents
{
    public class EventArgs<T> : EventArgs
    {
        public T Argument { get; set; }

        public EventArgs()
            : base()
        {

        }

        public EventArgs(T argument)
            : base()
        {
            this.Argument = argument;
        }
    }

    public class MyEventRaiser
    {
        public event EventHandler<EventArgs<string>> MyEvent = delegate { };

        public void Process(string data)
        {
            // do something interestuing

            Thread.Sleep(2000);

            var tmp = this.MyEvent;

            if (!string.IsNullOrEmpty(data))
            {
                tmp(this, new EventArgs<string>(data + " at: " + DateTime.Now.ToString()));
            }
        }
    }
}
