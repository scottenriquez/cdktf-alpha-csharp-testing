using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride")]
    public class AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride : aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride
    {
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WeightedCapacity
        {
            get;
            set;
        }
    }
}
