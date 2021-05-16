using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplate), fullyQualifiedName: "aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplate")]
    public interface IAutoscalingGroupMixedInstancesPolicyLaunchTemplate
    {
        /// <summary>launch_template_specification block.</summary>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification\"},\"kind\":\"array\"}}")]
        aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification[] LaunchTemplateSpecification
        {
            get;
        }

        /// <summary>override block.</summary>
        [JsiiProperty(name: "override", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride[]? Override
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplate), fullyQualifiedName: "aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template_specification block.</summary>
            [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification\"},\"kind\":\"array\"}}")]
            public aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification[] LaunchTemplateSpecification
            {
                get => GetInstanceProperty<aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification[]>()!;
            }

            /// <summary>override block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "override", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride[]? Override
            {
                get => GetInstanceProperty<aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride[]?>();
            }
        }
    }
}
