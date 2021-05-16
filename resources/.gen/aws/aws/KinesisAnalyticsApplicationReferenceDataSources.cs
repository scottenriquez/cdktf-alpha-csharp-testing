using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationReferenceDataSources")]
    public class KinesisAnalyticsApplicationReferenceDataSources : aws.IKinesisAnalyticsApplicationReferenceDataSources
    {
        /// <summary>s3 block.</summary>
        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesS3\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisAnalyticsApplicationReferenceDataSourcesS3[] S3
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchema[] Schema
        {
            get;
            set;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TableName
        {
            get;
            set;
        }
    }
}
