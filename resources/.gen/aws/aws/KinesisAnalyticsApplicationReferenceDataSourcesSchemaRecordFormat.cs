using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat : aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat
    {
        /// <summary>mapping_parameters block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mappingParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters[]? MappingParameters
        {
            get;
            set;
        }
    }
}
