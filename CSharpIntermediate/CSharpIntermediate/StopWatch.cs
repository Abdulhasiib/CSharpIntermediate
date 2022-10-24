using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class StopWatch
    {
        private bool _start;
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _recordedTime;

        public void start()
        {
            if (_start)
            {
                throw new InvalidOperationException("Stopwatch already started. Please stop the running instance before starting it again.");
            }

            Console.WriteLine("Starting Stopwatch...");

            _startTime = DateTime.Now;
            _start = true;

        }

        public TimeSpan stop()
        {
            if (_start == false)
            {
                throw new InvalidOperationException("Stopwatch is not started. It must be started before stopping.");
            }

            Console.WriteLine("Stopping Stopwatch");

            _stopTime = DateTime.Now;

            _recordedTime = _stopTime - _startTime;

            _start = false;
            
            return _recordedTime;
        }

    }

}
