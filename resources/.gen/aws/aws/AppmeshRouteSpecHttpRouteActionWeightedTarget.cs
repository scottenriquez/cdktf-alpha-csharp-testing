using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshRouteSpecHttpRouteActionWeightedTarget")]
    public class AppmeshRouteSpecHttpRouteActionWeightedTarget : aws.IAppmeshRouteSpecHttpRouteActionWeightedTarget
    {
        [JsiiProperty(name: "virtualNode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VirtualNode
        {
            get;
            set;
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Weight
        {
            get;
            set;
        }
    }
}
