using System.Threading;

namespace Demo.Counters.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IEligibilityCounters counters = new EligibilityCounters();
            var service = new Service(counters);

            while(true)
            {
                //service.ExecuteWithDependencyInjection();
                service.ExecuteWithFunctionalAspect();
                Thread.Sleep(1000);
            }
        }
    }
}
