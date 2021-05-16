using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicy), fullyQualifiedName: "aws.AutoscalingGroupMixedInstancesPolicy")]
    public interface IAutoscalingGroupMixedInstancesPolicy
    {
        /// <summary>launch_template block.</summary>
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"},\"kind\":\"array\"}}")]
        aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate[] LaunchTemplate
        {
            get;
        }

        /// <summary>instances_distribution block.</summary>
        [JsiiProperty(name: "instancesDistribution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution[]? InstancesDistribution
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicy), fullyQualifiedName: "aws.AutoscalingGroupMixedInstancesPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingGroupMixedInstancesPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template block.</summary>
            [JsiiProperty(name: "launchTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"},\"kind\":\"array\"}}")]
            public aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate[] LaunchTemplate
            {
                get => GetInstanceProperty<aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate[]>()!;
            }

            /// <summary>instances_distribution block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instancesDistribution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution[]? InstancesDistribution
            {
                get => GetInstanceProperty<aws.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution[]?>();
            }
        }
    }
}
