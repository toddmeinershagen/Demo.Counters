using Magnum.PerformanceCounters;

namespace Demo.Counters.ConsoleUI
{
    public class Eligibility_MedDataCounters : CounterCategory, IEligibility_MedDataCounters, IMonitorableCounter
    {
        public Counter Requests_Succeeded { get; set; }
        public Counter Requests_Failed { get; set; }
        public Counter Requests_Response_Time { get; set; }
    }

    public class Eligibility_ProdigoCounters : CounterCategory, IMonitorableCounter
    {
        public Counter Requests_Succeeded { get; set; }
        public Counter Requests_Failed { get; set; }
        public Counter Requests_Response_Time { get; set; }
    }
}