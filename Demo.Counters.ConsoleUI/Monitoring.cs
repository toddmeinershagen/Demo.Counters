using System;
using System.Diagnostics;
using Magnum.PerformanceCounters;

namespace Demo.Counters.ConsoleUI
{
    public static class Monitoring<TCounter>
        where TCounter : class, IMonitorableCounter, CounterCategory, new()
    {
        private static readonly CounterRepository _repository;

        static Monitoring()
        {
            _repository = CounterRepositoryConfigurator.New(cfg => cfg.Register<TCounter>());
        }

        public static void Monitor(Func<bool> function)
        {
            var counter = _repository.GetCounter<TCounter>("_default");
            var watch = new Stopwatch();

            try
            {
                watch.Start();

                if (function())
                    counter.Requests_Succeeded.Increment();
                else
                    counter.Requests_Failed.Increment();
            }
            catch (Exception)
            {
                counter.Requests_Failed.Increment();
                throw;
            }
            finally
            {
                watch.Stop();
                counter.Requests_Response_Time.Set(watch.Elapsed.Milliseconds);
            }
        }
    }
}
