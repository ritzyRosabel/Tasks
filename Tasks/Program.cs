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
            Task Parent = new Task(() =>
            {
                Task Child = new Task(() =>
                {

                });
            });
        }
    }
}
