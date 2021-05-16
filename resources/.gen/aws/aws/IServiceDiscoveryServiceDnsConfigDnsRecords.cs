using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IServiceDiscoveryServiceDnsConfigDnsRecords), fullyQualifiedName: "aws.ServiceDiscoveryServiceDnsConfigDnsRecords")]
    public interface IServiceDiscoveryServiceDnsConfigDnsRecords
    {
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        double Ttl
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceDiscoveryServiceDnsConfigDnsRecords), fullyQualifiedName: "aws.ServiceDiscoveryServiceDnsConfigDnsRecords")]
        internal sealed class _Proxy : DeputyBase, aws.IServiceDiscoveryServiceDnsConfigDnsRecords
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
            public double Ttl
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
