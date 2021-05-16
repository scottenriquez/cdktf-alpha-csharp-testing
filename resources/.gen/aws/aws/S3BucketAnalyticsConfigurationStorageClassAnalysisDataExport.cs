using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport")]
    public class S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport : aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport
    {
        /// <summary>destination block.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination[] Destination
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OutputSchemaVersion
        {
            get;
            set;
        }
    }
}
