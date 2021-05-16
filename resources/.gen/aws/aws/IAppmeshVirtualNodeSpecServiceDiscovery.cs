using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscovery), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecServiceDiscovery")]
    public interface IAppmeshVirtualNodeSpecServiceDiscovery
    {
        /// <summary>aws_cloud_map block.</summary>
        [JsiiProperty(name: "awsCloudMap", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap[]? AwsCloudMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>dns block.</summary>
        [JsiiProperty(name: "dns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecServiceDiscoveryDns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecServiceDiscoveryDns[]? Dns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscovery), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecServiceDiscovery")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecServiceDiscovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_cloud_map block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsCloudMap", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap[]? AwsCloudMap
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap[]?>();
            }

            /// <summary>dns block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecServiceDiscoveryDns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecServiceDiscoveryDns[]? Dns
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecServiceDiscoveryDns[]?>();
            }
        }
    }
}
