using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters")]
    public class KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters : aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters
    {
        /// <summary>csv block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "csv", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv[]? Csv
        {
            get;
            set;
        }

        /// <summary>json block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson[]? Json
        {
            get;
            set;
        }
    }
}
