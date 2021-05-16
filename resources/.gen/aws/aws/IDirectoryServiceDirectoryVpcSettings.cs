using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDirectoryServiceDirectoryVpcSettings), fullyQualifiedName: "aws.DirectoryServiceDirectoryVpcSettings")]
    public interface IDirectoryServiceDirectoryVpcSettings
    {
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

        [JsiiTypeProxy(nativeType: typeof(IDirectoryServiceDirectoryVpcSettings), fullyQualifiedName: "aws.DirectoryServiceDirectoryVpcSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IDirectoryServiceDirectoryVpcSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
