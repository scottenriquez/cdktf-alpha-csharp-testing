using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsCapacityProviderAutoScalingGroupProvider")]
    public class EcsCapacityProviderAutoScalingGroupProvider : aws.IEcsCapacityProviderAutoScalingGroupProvider
    {
        [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AutoScalingGroupArn
        {
            get;
            set;
        }

        /// <summary>managed_scaling block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedScaling", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling[]? ManagedScaling
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedTerminationProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ManagedTerminationProtection
        {
            get;
            set;
        }
    }
}
