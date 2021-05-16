using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Route53RecordLatencyRoutingPolicy")]
    public class Route53RecordLatencyRoutingPolicy : aws.IRoute53RecordLatencyRoutingPolicy
    {
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Region
        {
            get;
            set;
        }
    }
}
