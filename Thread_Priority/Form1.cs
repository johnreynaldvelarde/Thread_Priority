using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_Priority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Threads()
        {
            Console.WriteLine("-Before starting thread-");

         
            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadA.Name = "Thread A Process";


            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadB.Name = "Thread B Process";

            Thread threadC = new Thread(new ThreadStart(MyThreadClass.Thread1));
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadC.Name = "Thread C Process";

            Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;
            threadD.Name = "Thread D Process";



            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();



            lblThreadStart.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Threads();
        }
    }
}
