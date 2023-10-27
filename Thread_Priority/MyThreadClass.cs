using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Priority
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }
        }
        public static void Thread2()
        {
            for (int j = 0; j < 6; j++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + j);
                Thread.Sleep(TimeSpan.FromSeconds(1.5));
            }
        }
    }
}
