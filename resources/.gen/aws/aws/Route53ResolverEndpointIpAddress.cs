using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Route53ResolverEndpointIpAddress")]
    public class Route53ResolverEndpointIpAddress : aws.IRoute53ResolverEndpointIpAddress
    {
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SubnetId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Ip
        {
            get;
            set;
        }
    }
}
