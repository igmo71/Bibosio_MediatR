using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace Bibosio.WebApp
{
    public class AppInstrumentation
    {
        internal static string ActivitySourceName = $"{nameof(Bibosio)}.AppActivitySource";
        internal const string MeterName = $"{nameof(Bibosio)}.AppMeter";

        public AppInstrumentation()
        {
            string? version = typeof(AppInstrumentation).Assembly.GetName().Version?.ToString();

            ActivitySource = new ActivitySource(ActivitySourceName, version);
            Meter = new Meter(MeterName, version);
            Counters = new();
            TodoCreatedCounter = Meter.CreateCounter<long>("todo.created", description: "The number of Todo Created");
        }

        public ActivitySource ActivitySource { get; }

        public Meter Meter { get; }

        public Dictionary<string, object> Counters { get; set; }

        public void CreateCounter<T>(string counterName) where T : struct
        {
            if (!Counters.ContainsKey(counterName))
            {
                var counter = Meter.CreateCounter<T>(counterName);
                Counters.Add(counterName, counter);
            }
        }

        public Counter<long> TodoCreatedCounter { get; }

        public void Dispose()
        {
            this.ActivitySource.Dispose();
            this.Meter.Dispose();
        }
    }
}
