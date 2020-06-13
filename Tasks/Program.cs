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
            try
            {
                      t.Call();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.ReadLine();
        }
    }
}
