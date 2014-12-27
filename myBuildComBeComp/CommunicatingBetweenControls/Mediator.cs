using CommunicatingBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatingBetweenControls
{
    public sealed class Mediator
    {
        private static readonly Mediator _Instance = new Mediator();

        public event EventHandler<JobChangeArgs> JobChanged;
        private Mediator()
        {

        }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        //this is where the event rasier code will call the delagates.
        public void OnJobChanged(Object sender, Job job)
        {
            if (JobChanged != null)
            {
                JobChanged(sender, new JobChangeArgs() { Job = job });
            }
        }
    }
}
