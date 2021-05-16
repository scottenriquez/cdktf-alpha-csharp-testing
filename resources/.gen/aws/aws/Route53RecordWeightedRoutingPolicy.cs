using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Route53RecordWeightedRoutingPolicy")]
    public class Route53RecordWeightedRoutingPolicy : aws.IRoute53RecordWeightedRoutingPolicy
    {
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Weight
        {
            get;
            set;
        }
    }
}
