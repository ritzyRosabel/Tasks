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
               Task.Delay(2000);
               throw new Exception("my own exception");
          });
        }
        
        public async void Call()
        {
            // you cannot use the await keyword on a void asynchronous method
            await ShowAsync();
        }
    }
}
