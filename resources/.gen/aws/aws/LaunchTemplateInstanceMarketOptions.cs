using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplateInstanceMarketOptions")]
    public class LaunchTemplateInstanceMarketOptions : aws.ILaunchTemplateInstanceMarketOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MarketType
        {
            get;
            set;
        }

        /// <summary>spot_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateInstanceMarketOptionsSpotOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateInstanceMarketOptionsSpotOptions[]? SpotOptions
        {
            get;
            set;
        }
    }
}
