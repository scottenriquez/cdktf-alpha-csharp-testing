using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ServiceDiscoveryServiceDnsConfig")]
    public class ServiceDiscoveryServiceDnsConfig : aws.IServiceDiscoveryServiceDnsConfig
    {
        /// <summary>dns_records block.</summary>
        [JsiiProperty(name: "dnsRecords", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IServiceDiscoveryServiceDnsConfigDnsRecords[] DnsRecords
        {
            get;
            set;
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NamespaceId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RoutingPolicy
        {
            get;
            set;
        }
    }
}
