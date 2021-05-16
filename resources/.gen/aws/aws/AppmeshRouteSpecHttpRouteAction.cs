using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshRouteSpecHttpRouteAction")]
    public class AppmeshRouteSpecHttpRouteAction : aws.IAppmeshRouteSpecHttpRouteAction
    {
        /// <summary>weighted_target block.</summary>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteActionWeightedTarget\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAppmeshRouteSpecHttpRouteActionWeightedTarget[] WeightedTarget
        {
            get;
            set;
        }
    }
}
