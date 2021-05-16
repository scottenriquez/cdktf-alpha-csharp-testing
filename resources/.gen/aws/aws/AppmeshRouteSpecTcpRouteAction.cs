using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshRouteSpecTcpRouteAction")]
    public class AppmeshRouteSpecTcpRouteAction : aws.IAppmeshRouteSpecTcpRouteAction
    {
        /// <summary>weighted_target block.</summary>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecTcpRouteActionWeightedTarget\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAppmeshRouteSpecTcpRouteActionWeightedTarget[] WeightedTarget
        {
            get;
            set;
        }
    }
}
