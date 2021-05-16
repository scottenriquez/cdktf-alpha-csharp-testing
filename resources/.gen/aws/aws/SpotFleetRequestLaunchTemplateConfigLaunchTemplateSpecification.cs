using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification")]
    public class SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification : aws.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification
    {
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Id
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
