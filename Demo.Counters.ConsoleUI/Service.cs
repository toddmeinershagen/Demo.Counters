using System;
using System.Threading;

namespace Demo.Counters.ConsoleUI
{
    public class Service
    {
        private readonly IEligibilityCounters _counters;
        
        public Service(IEligibilityCounters counters)
        {
            _counters = counters;
        }

        public void ExecuteWithDependencyInjection()
        {
            var generator = new Random();
            var nextNumber = generator.Next(100);

            if (nextNumber%2 == 0)
            {
                _counters.MedData.Requests_Succeeded.Increment();
            }
            else
            {
                _counters.MedData.Requests_Failed.Increment();
            }

            _counters.MedData.Requests_Response_Time.Set(nextNumber);
        }

        public void ExecuteWithFunctionalAspect()
        {
            var generator = new Random();
            int nextNumber = generator.Next(100);

            Monitoring<Eligibility_MedDataCounters>.Monitor(GetFunction(nextNumber));

            nextNumber = generator.Next(100);
            Monitoring<Eligibility_ProdigoCounters>.Monitor(GetFunction(nextNumber));
        }

        public Func<bool> GetFunction(int nextNumber)
        {
            return () =>
                {
                    Thread.Sleep(nextNumber);
                    return nextNumber%2 == 0;
                };
        }
    }
}