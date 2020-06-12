using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task is a basic unit of the Task parrallel library
            //can perform the following  with a task
            // start/run
            //wait
            //cancel
            //have a child task
            Task t = new Task(() =>
            {

                System.Threading.Thread.Sleep(5000);

                Console.WriteLine("Child Task finished");
            });
            Console.WriteLine(t.Status);

            t.Start();
            Console.WriteLine(t.Status);

            t.Wait();
            Console.WriteLine(t.Status);
            Console.WriteLine("End Of Main");


            Console.ReadLine();
        }
    }
}
