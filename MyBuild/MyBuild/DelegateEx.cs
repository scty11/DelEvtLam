using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    public delegate void SomeWork(int value,WorkType aType );
    public enum WorkType{Meeting, PaperWork};
    
    class DelegateEx
    {
        public static void Example()
        {
            SomeWork s1 = new SomeWork(Work1);
            SomeWork s2 = new SomeWork(Work2);
            s1 += s2;
            Work3(s1);
        }

        static void Work3(SomeWork v)
        {
            
            v(4, WorkType.Meeting);
        }
        static void Work1(int v, WorkType t)
        {
            Console.WriteLine("At {0} - {1}",v , t.ToString());
        }

        static void Work2(int v, WorkType t)
        {
            Console.WriteLine("At {0} - {1}", v + 1, t.ToString());
        }

    }
}
