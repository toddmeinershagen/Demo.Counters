using System;

namespace Demo.Counters.ConsoleUI
{
    public interface IEligibilityCounters : IDisposable
    {
        IEligibility_MedDataCounters MedDataCounters { get; }
    }
}