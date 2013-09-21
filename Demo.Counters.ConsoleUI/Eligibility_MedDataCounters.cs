using Magnum.PerformanceCounters;

namespace Demo.Counters.ConsoleUI
{
    public class Eligibility_MedDataCounters : CounterCategory, IEligibility_MedDataCounters
    {
        public Counter Requests_Succeeded { get; set; }
        public Counter Requests_Failed { get; set; }
        public Counter Requests_Response_Time { get; set; }
    }
}