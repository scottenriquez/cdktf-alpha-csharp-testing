using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride), fullyQualifiedName: "aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride")]
    public interface IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride
    {
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeightedCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride), fullyQualifiedName: "aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeightedCapacity
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
