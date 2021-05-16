using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlobalacceleratorAcceleratorAttributes")]
    public class GlobalacceleratorAcceleratorAttributes : aws.IGlobalacceleratorAcceleratorAttributes
    {
        [JsiiOptional]
        [JsiiProperty(name: "flowLogsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? FlowLogsEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowLogsS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FlowLogsS3Bucket
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowLogsS3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FlowLogsS3Prefix
        {
            get;
            set;
        }
    }
}
