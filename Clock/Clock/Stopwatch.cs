using System;

namespace Clock
{
    class Stopwatch
    {

        private bool _isRunning = false;
        private DateTime _nowTime;
        public string Butt { get; set; }


        public void Start()
        {
            if (_isRunning)
                throw new System.ArgumentException("You cannot initialize twice");

            else
            {

                _nowTime = DateTime.Now;
                _isRunning = true;
            }

        }
        public void Stop()
        {
            if (!_isRunning)
                throw new System.ArgumentException("Stopwatch is doesn't running");
            else
            {
                var timeSpan = DateTime.Now - _nowTime;
                Console.WriteLine($"The Count : {timeSpan.Hours}:{timeSpan.Minutes}:{timeSpan.Seconds}:{timeSpan.Milliseconds}");

                _isRunning = false;
            }
            
        }
    }

}
