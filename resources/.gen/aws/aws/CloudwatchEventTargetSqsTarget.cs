using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CloudwatchEventTargetSqsTarget")]
    public class CloudwatchEventTargetSqsTarget : aws.ICloudwatchEventTargetSqsTarget
    {
        [JsiiOptional]
        [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MessageGroupId
        {
            get;
            set;
        }
    }
}
