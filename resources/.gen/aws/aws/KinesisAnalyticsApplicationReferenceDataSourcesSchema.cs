using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchema")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchema : aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchema
    {
        /// <summary>record_columns block.</summary>
        [JsiiProperty(name: "recordColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns[] RecordColumns
        {
            get;
            set;
        }

        /// <summary>record_format block.</summary>
        [JsiiProperty(name: "recordFormat", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat[] RecordFormat
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RecordEncoding
        {
            get;
            set;
        }
    }
}
