using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    //public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);
    class EventEx
    {
        //public event WorkPerformedHandler WorkPerformed;

        //These two commeneted out can be replaced by the EventHandler<t> if we dont
        //wish to use the delagate directly. as shown above

        public event EventHandler<EventArgsEx> WorkPerformed;
        public event EventHandler WorkComplete;

        public void DoWork(int hour, WorkType y) 
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Delay(1000).Wait();
                //On.... is a naming convention for the event.
                OnWorkPerformed(i + 1, y);
            }
            OnWorkComplete();
        }

        //The On methods are virtual so they can overidden
        protected virtual void OnWorkComplete()
        {
            if (WorkComplete != null)
            {
                WorkComplete(this, EventArgs.Empty);
            }
        }

        protected virtual void OnWorkPerformed(int p, WorkType y)
        {
            //two ways to invoke the delegate. 
            //using the event it self.
            if (WorkPerformed != null)
            {
                WorkPerformed(this, new EventArgsEx(p,y));
            }
            //or using the underlying delegate directly.

            //var del = WorkPerformed as EventHandler<EventArgsEx>;
            //if (del != null)
            //{
            //    del(this, new EventArgsEx(p, y));
            //}
        }
    }
}
