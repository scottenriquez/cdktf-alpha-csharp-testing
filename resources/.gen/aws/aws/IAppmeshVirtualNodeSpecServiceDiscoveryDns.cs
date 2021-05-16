using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscoveryDns), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecServiceDiscoveryDns")]
    public interface IAppmeshVirtualNodeSpecServiceDiscoveryDns
    {
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscoveryDns), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecServiceDiscoveryDns")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecServiceDiscoveryDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
