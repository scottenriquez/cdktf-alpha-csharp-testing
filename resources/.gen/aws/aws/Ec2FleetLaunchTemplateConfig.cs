using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Ec2FleetLaunchTemplateConfig")]
    public class Ec2FleetLaunchTemplateConfig : aws.IEc2FleetLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification[] LaunchTemplateSpecification
        {
            get;
            set;
        }

        /// <summary>override block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "override", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfigOverride\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEc2FleetLaunchTemplateConfigOverride[]? Override
        {
            get;
            set;
        }
    }
}
