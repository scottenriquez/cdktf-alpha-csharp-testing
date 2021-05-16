using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination")]
    public class S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination : aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination
    {
        /// <summary>s3_bucket_destination block.</summary>
        [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination[] S3BucketDestination
        {
            get;
            set;
        }
    }
}
