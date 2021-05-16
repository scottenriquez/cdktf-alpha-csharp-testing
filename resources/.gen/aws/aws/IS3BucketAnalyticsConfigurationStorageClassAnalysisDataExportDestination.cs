using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination
    {
        /// <summary>s3_bucket_destination block.</summary>
        [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"},\"kind\":\"array\"}}")]
        aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination[] S3BucketDestination
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_bucket_destination block.</summary>
            [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination[] S3BucketDestination
            {
                get => GetInstanceProperty<aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination[]>()!;
            }
        }
    }
}
