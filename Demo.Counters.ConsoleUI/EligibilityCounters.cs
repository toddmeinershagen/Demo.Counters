using System;
using Magnum.PerformanceCounters;

namespace Demo.Counters.ConsoleUI
{
    public class EligibilityCounters : IEligibilityCounters
    {
        private CounterRepository _repository;

        public EligibilityCounters()
        {
            _repository = CounterRepositoryConfigurator.New(cfg => cfg.Register<Eligibility_MedDataCounters>());
            MedDataCounters = _repository.GetCounter<Eligibility_MedDataCounters>("_default");
        }

        public IEligibility_MedDataCounters MedDataCounters { get; private set; }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_repository != null)
                {
                    _repository.Dispose();
                    _repository = null;
                }
            }
        }
    }
}