using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.BatchComputeEnvironmentComputeResourcesLaunchTemplate")]
    public class BatchComputeEnvironmentComputeResourcesLaunchTemplate : aws.IBatchComputeEnvironmentComputeResourcesLaunchTemplate
    {
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

        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
