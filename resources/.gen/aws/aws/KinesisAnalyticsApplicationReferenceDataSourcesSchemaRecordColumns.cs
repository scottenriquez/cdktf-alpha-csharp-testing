using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns : aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SqlType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Mapping
        {
            get;
            set;
        }
    }
}
