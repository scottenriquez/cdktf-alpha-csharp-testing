using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplateInstanceMarketOptionsSpotOptions")]
    public class LaunchTemplateInstanceMarketOptionsSpotOptions : aws.ILaunchTemplateInstanceMarketOptionsSpotOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BlockDurationMinutes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceInterruptionBehavior
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxPrice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SpotInstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ValidUntil
        {
            get;
            set;
        }
    }
}
