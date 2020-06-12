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
            Task Parent = new Task(() =>
            {
                Task Child = new Task(() =>
                {
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("finished  sleep");
                });
                Child.Start();
                Child.Wait();
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Child Task finished");
            });

            Parent.Start();
            Parent.Wait(1000);
            Console.ReadLine();
        }
    }
}
