using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationOutputsSchema")]
    public class KinesisAnalyticsApplicationOutputsSchema : aws.IKinesisAnalyticsApplicationOutputsSchema
    {
        [JsiiOptional]
        [JsiiProperty(name: "recordFormatType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RecordFormatType
        {
            get;
            set;
        }
    }
}
