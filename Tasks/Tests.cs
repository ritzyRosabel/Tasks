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

Task response;
        public Task ShowAsync()
        { 
               return  Task.Run(() => { Console.WriteLine("Executing fourth task"); }); 
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
        //can wrapping only the method call of the Task method handle task exception?
        //answer System.Exception: 'my own exception' unhandled exceptiom, if the exception occurs within the task 
        // however, if the exception occurs outside the task the exxception is handled by the try catch the caller method implemented
        // my own exception
        // can 

    }
}
