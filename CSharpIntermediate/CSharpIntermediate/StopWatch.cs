using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class StopWatch
    {
        private DateTime? stopWatchStarted = null;
        private DateTime stopWatchStop;

        public DateTime? start()
        {
            if (stopWatchStarted != null)
            {
                throw new InvalidOperationException();
            }
            stopWatchStarted = DateTime.Now;

            return stopWatchStarted;
        }

        public DateTime? stop()
        {
            stopWatchStop = DateTime.Now;
            stopWatchStarted = null;

            return stopWatchStop;
        }
    }

}
