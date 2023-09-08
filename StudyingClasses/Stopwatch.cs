using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingClasses
{
    public class MyTimer
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning = false;

        public void Start(bool reset = false)
        {
            if (_isRunning && !reset)
            {
                throw new InvalidOperationException("Timer is already running! If you wanted to restart consider passing true as parameter.");
            }

            _startTime = DateTime.Now;

            Console.WriteLine($"in Start: {_startTime.Hour}:{_startTime.Minute}:{_startTime.Second}");

            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running!");
            }

            _isRunning = false;
        }

        public TimeSpan GetCurrentTime()
        {                      

            return _endTime - _startTime;
        }
    }
}
