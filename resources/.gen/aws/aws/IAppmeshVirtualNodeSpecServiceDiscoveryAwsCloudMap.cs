using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap")]
    public interface IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap
    {
        [JsiiProperty(name: "namespaceName", typeJson: "{\"primitive\":\"string\"}")]
        string NamespaceName
        {
            get;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceName
        {
            get;
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Attributes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "namespaceName", typeJson: "{\"primitive\":\"string\"}")]
            public string NamespaceName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Attributes
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
