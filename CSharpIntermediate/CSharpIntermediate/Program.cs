using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stopWatch = new StopWatch();

                DateTime start = (DateTime)stopWatch.start();

                //DateTime startagain = (DateTime)stopWatch.start();

                Thread.Sleep(11000);

                DateTime stop = (DateTime)stopWatch.stop();

                TimeSpan timeDuration = stop - start;
                Console.WriteLine(timeDuration);
                Console.ReadLine();
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            
        }
    }
}
