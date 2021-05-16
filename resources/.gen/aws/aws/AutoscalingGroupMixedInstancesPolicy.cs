using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AutoscalingGroupMixedInstancesPolicy")]
    public class AutoscalingGroupMixedInstancesPolicy : aws.IAutoscalingGroupMixedInstancesPolicy
    {
        /// <summary>launch_template block.</summary>
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate[] LaunchTemplate
        {
            get;
            set;
        }

        /// <summary>instances_distribution block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instancesDistribution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution[]? InstancesDistribution
        {
            get;
            set;
        }
    }
}
