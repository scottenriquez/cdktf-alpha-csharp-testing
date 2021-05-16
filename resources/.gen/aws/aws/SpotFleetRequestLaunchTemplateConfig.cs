using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SpotFleetRequestLaunchTemplateConfig")]
    public class SpotFleetRequestLaunchTemplateConfig : aws.ISpotFleetRequestLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification[] LaunchTemplateSpecification
        {
            get;
            set;
        }

        /// <summary>overrides block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overrides", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchTemplateConfigOverrides\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISpotFleetRequestLaunchTemplateConfigOverrides[]? Overrides
        {
            get;
            set;
        }
    }
}
