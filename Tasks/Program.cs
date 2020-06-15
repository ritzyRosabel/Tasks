using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Tests t = new Tests();
            t.Call();

            await  TaskAsTypeInAsyncMethod.ExecuteAsync();
            Console.ReadLine();
            //Executing fourth task
            //the square  of1 is : 1
            //the square  of2 is : 4
            //the square  of3 is : 9
            //the square  of4 is : 16
            //the square  of5 is : 25
            //the square  of6 is : 36
            //the square  of7 is : 49
            //the square  of8 is : 64
            //the square  of9 is : 81
            //the square  of10 is : 100
            // pop quiz
            // if a task from a list of tasks throws an exception, does the program continue to run the other tasks after it? does the program exit?
            //System.Exception: 'my exception' it gives an unhandled exception but it keep running other task. 
        }
    }
}
