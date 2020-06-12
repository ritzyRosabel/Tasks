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

            t.Start();
            Console.WriteLine("Cancelled:- "+t.IsCanceled);
            Console.WriteLine("Cancelled:- "+t.IsCompleted);
            Console.WriteLine("Cancelled:- "+t.IsFaulted);
            Console.WriteLine(t.Status);
            Console.WriteLine("End Of Main");
             //Cancelled:- False
            // Cancelled: -False
            //Cancelled: -False
            //Running
            //End Of Main
            //Child Task finished

            Console.ReadLine();
        }
    }
}
