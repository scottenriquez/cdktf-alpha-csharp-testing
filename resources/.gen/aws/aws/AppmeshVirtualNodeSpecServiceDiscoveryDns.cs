using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecServiceDiscoveryDns")]
    public class AppmeshVirtualNodeSpecServiceDiscoveryDns : aws.IAppmeshVirtualNodeSpecServiceDiscoveryDns
    {
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Hostname
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServiceName
        {
            get;
            set;
        }
    }
}
