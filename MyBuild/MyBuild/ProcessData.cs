using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    class ProcessData
    {
        public static int ProcessSomeData(int x, int y, ProcessedDelegate del)
        {
            return del(x, y);
        }

        public static void OtherData(int x, int y, Action<int, int>action){
            
            action(x, y);
        }

        public static void FuncAdd(int p1, int p2, Func<int, int, int> reAdee)
        {
            Console.WriteLine(reAdee(p1,p2));
        }
    }
}
