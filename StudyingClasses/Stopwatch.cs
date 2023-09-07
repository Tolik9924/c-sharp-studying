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
        public bool IsRunning = false;

        public void Start(bool reset = false)
        {
            if (IsRunning && !reset)
            {
                throw new InvalidOperationException("Timer is already running! If you wanted to restart consider passing true as parameter.");
            }

            _startTime = DateTime.Now;

            Console.WriteLine($"in Start: {_startTime.Hour}:{_startTime.Minute}:{_startTime.Second}");

            IsRunning = true;
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public string GetCurrentTime()
        {
            if (!IsRunning)
            {
                Console.WriteLine("Trying to get a time from a Timer that isn't running!");
                return "--:--:---";
            }

            DateTime endTime = DateTime.Now;

            TimeSpan timeDifference =  endTime.Subtract(_startTime);

            return $"{timeDifference}";
        }
    }
}
