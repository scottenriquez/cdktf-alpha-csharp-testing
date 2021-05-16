using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters : aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters
    {
        /// <summary>csv block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "csv", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv[]? Csv
        {
            get;
            set;
        }

        /// <summary>json block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson[]? Json
        {
            get;
            set;
        }
    }
}
