using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.EcsCapacityProviderAutoScalingGroupProviderManagedScaling")]
    public class EcsCapacityProviderAutoScalingGroupProviderManagedScaling : aws.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling
    {
        [JsiiOptional]
        [JsiiProperty(name: "maximumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumScalingStepSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumScalingStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinimumScalingStepSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Status
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TargetCapacity
        {
            get;
            set;
        }
    }
}
