using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination")]
    public class S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination : aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination
    {
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BucketArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BucketAccountId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Format
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
