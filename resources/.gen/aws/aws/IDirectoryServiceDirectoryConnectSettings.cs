using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDirectoryServiceDirectoryConnectSettings), fullyQualifiedName: "aws.DirectoryServiceDirectoryConnectSettings")]
    public interface IDirectoryServiceDirectoryConnectSettings
    {
        [JsiiProperty(name: "customerDnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CustomerDnsIps
        {
            get;
        }

        [JsiiProperty(name: "customerUsername", typeJson: "{\"primitive\":\"string\"}")]
        string CustomerUsername
        {
            get;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDirectoryServiceDirectoryConnectSettings), fullyQualifiedName: "aws.DirectoryServiceDirectoryConnectSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IDirectoryServiceDirectoryConnectSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "customerDnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CustomerDnsIps
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "customerUsername", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomerUsername
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
