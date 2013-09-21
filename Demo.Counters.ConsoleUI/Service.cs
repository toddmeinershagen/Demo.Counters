using System;

namespace Demo.Counters.ConsoleUI
{
    public class Service
    {
        private readonly IEligibilityCounters _counters;
        
        public Service(IEligibilityCounters counters)
        {
            _counters = counters;
        }

        public void Execute()
        {
            var generator = new Random();
            var nextNumber = generator.Next(100);

            if (nextNumber%2 == 0)
            {
                _counters.MedDataCounters.Requests_Succeeded.Increment();
            }
            else
            {
                _counters.MedDataCounters.Requests_Failed.Increment();
            }

            _counters.MedDataCounters.Requests_Response_Time.Set(generator.Next(100));
        }
    }
}