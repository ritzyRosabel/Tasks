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


        public Task ShowAsync()
        {
            return Task.Run(() =>
            {

                try
                {
                    Task.Delay(2000);
                    throw new Exception("my own exception");

                    Console.WriteLine("finished the delay");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });
        }

        public async void Call()
        {
            try
            {
                await ShowAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //my own exception
        //A task was canceled.
        // when an aSYNCHRONOUS METHOD FAILS TO RUN A TASK IT THROWS A task was canceled exception so its good to put a try catch in the callers method to handle that exception
        //can we wrapping only the method call of the Task method handle task exception?

    }
}
