using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecServiceDiscovery")]
    public class AppmeshVirtualNodeSpecServiceDiscovery : aws.IAppmeshVirtualNodeSpecServiceDiscovery
    {
        /// <summary>aws_cloud_map block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsCloudMap", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap[]? AwsCloudMap
        {
            get;
            set;
        }

        /// <summary>dns block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecServiceDiscoveryDns\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecServiceDiscoveryDns[]? Dns
        {
            get;
            set;
        }
    }
}
