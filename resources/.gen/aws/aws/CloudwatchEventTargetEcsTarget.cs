using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudwatchEventTargetEcsTarget")]
    public class CloudwatchEventTargetEcsTarget : aws.ICloudwatchEventTargetEcsTarget
    {
        [JsiiProperty(name: "taskDefinitionArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TaskDefinitionArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Group
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LaunchType
        {
            get;
            set;
        }

        /// <summary>network_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetEcsTargetNetworkConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudwatchEventTargetEcsTargetNetworkConfiguration[]? NetworkConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PlatformVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TaskCount
        {
            get;
            set;
        }
    }
}
