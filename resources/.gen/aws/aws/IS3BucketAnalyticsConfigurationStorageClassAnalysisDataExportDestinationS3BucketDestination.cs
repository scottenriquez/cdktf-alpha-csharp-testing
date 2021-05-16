using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination
    {
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        string BucketArn
        {
            get;
        }

        [JsiiProperty(name: "bucketAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketAccountId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Format
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "bucketAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketAccountId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Format
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
