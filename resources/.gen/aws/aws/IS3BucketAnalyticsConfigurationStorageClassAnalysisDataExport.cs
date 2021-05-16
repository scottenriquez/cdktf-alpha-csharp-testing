using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport
    {
        /// <summary>destination block.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"},\"kind\":\"array\"}}")]
        aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination[] Destination
        {
            get;
        }

        [JsiiProperty(name: "outputSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputSchemaVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination[] Destination
            {
                get => GetInstanceProperty<aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "outputSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
