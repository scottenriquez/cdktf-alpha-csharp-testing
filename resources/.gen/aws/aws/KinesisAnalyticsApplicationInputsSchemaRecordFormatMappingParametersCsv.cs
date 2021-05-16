using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv")]
    public class KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv : aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv
    {
        [JsiiProperty(name: "recordColumnDelimiter", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RecordColumnDelimiter
        {
            get;
            set;
        }

        [JsiiProperty(name: "recordRowDelimiter", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RecordRowDelimiter
        {
            get;
            set;
        }
    }
}
