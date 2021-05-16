using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysis), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysis")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysis
    {
        /// <summary>data_export block.</summary>
        [JsiiProperty(name: "dataExport", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"},\"kind\":\"array\"}}")]
        aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport[] DataExport
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysis), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysis")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketAnalyticsConfigurationStorageClassAnalysis
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_export block.</summary>
            [JsiiProperty(name: "dataExport", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport[] DataExport
            {
                get => GetInstanceProperty<aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport[]>()!;
            }
        }
    }
}
