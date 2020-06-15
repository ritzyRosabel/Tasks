using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class TaskAsTypeInAsyncMethod
    {
        public static async Task ExecuteAsync( )
        {
            await foreach(var number in GetSequence()) { }

        }
        public static async IAsyncEnumerable<SquareNumber> GetSequence()
        {
            for(int i=1; i<=10; i++)
            {
                await Task.Delay(2000);
                yield
                    return new SquareNumber { Number = i, Square = i * i };
            }
        }

    }
    public class SquareNumber
    {
        public int Number { get; set; }
        public int Square { get; set; }
    }
}
