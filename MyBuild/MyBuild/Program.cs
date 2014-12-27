using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    public delegate int ProcessedDelegate(int x, int y);
    class Program
    {
        
        static void Main(string[] args)
        {
            //DelegateEx.Example();

            var eventEx = new EventEx();
            eventEx.WorkPerformed += eventEx_WorkPerformed;
            eventEx.WorkComplete += (x, y) => Console.WriteLine("The work has complete.");            
            //eventEx.WorkComplete += eventEx_WorkComplete;
            //eventEx.DoWork(5, WorkType.PaperWork);
           
            ProcessedDelegate AddDel = (x, y) => { return x + y; };
            ProcessedDelegate DelDel = (x, y) => { return x + y; };
            var result = ProcessData.ProcessSomeData(5, 1, AddDel);
            Console.WriteLine(result);

            //This removes the need to create a delegate like the one above Program.
            Action<int,int> ADel = (x,y) => { Console.WriteLine(x + y); };
            ProcessData.OtherData(5, 1, ADel);

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
