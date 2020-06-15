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
            Tests t = new Tests();
            t.Call();


            Console.ReadLine();
            // pop quiz
            // if a task from a list of tasks throws an exception, does the program continue to run the other tasks after it? does the program exit?
            //System.Exception: 'my exception' it gives an unhandled exception but it keep running other task. 
        }
    }
}
