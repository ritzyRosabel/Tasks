using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Tests
    {
        // task property delay 
        Task t = new Task(() =>
        {
            Task.Delay(2000);

        });
    }
}
