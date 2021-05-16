using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification")]
    public class Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification : aws.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification
    {
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Version
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LaunchTemplateId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LaunchTemplateName
        {
            get;
            set;
        }
    }
}
