using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magnum.PerformanceCounters;

namespace Demo.Counters.ConsoleUI
{
    public interface IMonitorableCounter
    {
        Counter Requests_Succeeded { get; set; }
        Counter Requests_Failed { get; set; }
        Counter Requests_Response_Time { get; set; }
    }
}
