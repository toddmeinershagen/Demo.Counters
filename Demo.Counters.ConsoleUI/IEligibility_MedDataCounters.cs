using Magnum.PerformanceCounters;

namespace Demo.Counters.ConsoleUI
{
    public interface IEligibility_MedDataCounters
    {
        Counter Requests_Succeeded { get; set; }
        Counter Requests_Failed { get; set; }
        Counter Requests_Response_Time { get; set; }
    }
}