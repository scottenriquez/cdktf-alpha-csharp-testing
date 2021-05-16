using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CloudwatchEventTargetKinesisTarget")]
    public class CloudwatchEventTargetKinesisTarget : aws.ICloudwatchEventTargetKinesisTarget
    {
        [JsiiOptional]
        [JsiiProperty(name: "partitionKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PartitionKeyPath
        {
            get;
            set;
        }
    }
}
