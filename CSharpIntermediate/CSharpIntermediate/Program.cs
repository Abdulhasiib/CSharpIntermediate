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

                stopWatch.start();

                stopWatch.start();

                Thread.Sleep(11000);

                TimeSpan _recordTime = stopWatch.stop();

                Console.WriteLine($"Time recorded: {_recordTime.Hours} HH : {_recordTime.Minutes} MM : {_recordTime.Seconds} SS");

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
