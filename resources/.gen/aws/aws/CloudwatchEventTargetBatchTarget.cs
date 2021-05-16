using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudwatchEventTargetBatchTarget")]
    public class CloudwatchEventTargetBatchTarget : aws.ICloudwatchEventTargetBatchTarget
    {
        [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string JobDefinition
        {
            get;
            set;
        }

        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string JobName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arraySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ArraySize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? JobAttempts
        {
            get;
            set;
        }
    }
}
