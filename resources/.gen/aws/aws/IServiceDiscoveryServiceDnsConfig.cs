using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IServiceDiscoveryServiceDnsConfig), fullyQualifiedName: "aws.ServiceDiscoveryServiceDnsConfig")]
    public interface IServiceDiscoveryServiceDnsConfig
    {
        /// <summary>dns_records block.</summary>
        [JsiiProperty(name: "dnsRecords", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}")]
        aws.IServiceDiscoveryServiceDnsConfigDnsRecords[] DnsRecords
        {
            get;
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        string NamespaceId
        {
            get;
        }

        [JsiiProperty(name: "routingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceDiscoveryServiceDnsConfig), fullyQualifiedName: "aws.ServiceDiscoveryServiceDnsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IServiceDiscoveryServiceDnsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dns_records block.</summary>
            [JsiiProperty(name: "dnsRecords", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}")]
            public aws.IServiceDiscoveryServiceDnsConfigDnsRecords[] DnsRecords
            {
                get => GetInstanceProperty<aws.IServiceDiscoveryServiceDnsConfigDnsRecords[]>()!;
            }

            [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string NamespaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "routingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
