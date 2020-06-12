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

                });
            });
        }
    }
}
