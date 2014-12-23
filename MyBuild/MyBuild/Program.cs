using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            //DelegateEx.Example();

            var eventEx = new EventEx();
            eventEx.WorkPerformed += eventEx_WorkPerformed;
            eventEx.WorkComplete += eventEx_WorkComplete;
            eventEx.DoWork(5, WorkType.PaperWork);
            Console.Read();
        }

        static void eventEx_WorkComplete(object sender, EventArgs e)
        {
            Console.WriteLine("The work has complete.");
        }

        static void eventEx_WorkPerformed(object sender, EventArgsEx e)
        {
            Console.WriteLine("Hours {0} : Work {1}.", e.Hours, e.WorkType);
        }
    }
}
