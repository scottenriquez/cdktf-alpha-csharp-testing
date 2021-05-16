using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudwatchEventTargetEcsTargetNetworkConfiguration")]
    public class CloudwatchEventTargetEcsTargetNetworkConfiguration : aws.ICloudwatchEventTargetEcsTargetNetworkConfiguration
    {
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Subnets
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AssignPublicIp
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }
    }
}
