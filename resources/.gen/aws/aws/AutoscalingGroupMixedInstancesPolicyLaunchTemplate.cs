using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplate")]
    public class AutoscalingGroupMixedInstancesPolicyLaunchTemplate : aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate
    {
        /// <summary>launch_template_specification block.</summary>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification[] LaunchTemplateSpecification
        {
            get;
            set;
        }

        /// <summary>override block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "override", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride[]? Override
        {
            get;
            set;
        }
    }
}
