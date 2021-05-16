using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap")]
    public class AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap : aws.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap
    {
        [JsiiProperty(name: "namespaceName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NamespaceName
        {
            get;
            set;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Attributes
        {
            get;
            set;
        }
    }
}
