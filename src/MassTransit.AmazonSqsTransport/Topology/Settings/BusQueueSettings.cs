namespace MassTransit.AmazonSqsTransport.Topology.Settings
{
    using System.Collections.Generic;


    public class BusQueueSettings
    {
        public string EntityName { get; set; }
        public ushort PrefetchCount { get; set; }
        public ushort WaitTimeSeconds { get; set; }
        public bool Durable { get; set; }
        public bool AutoDelete { get; set; } = true;
        public bool PurgeOnStartup { get; set; }
        public IDictionary<string, object> QueueAttributes { get; set; }
        public IDictionary<string, object> QueueSubscriptionAttributes { get; set; }
    }
}
