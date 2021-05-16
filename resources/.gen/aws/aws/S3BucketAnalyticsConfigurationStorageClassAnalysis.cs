using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketAnalyticsConfigurationStorageClassAnalysis")]
    public class S3BucketAnalyticsConfigurationStorageClassAnalysis : aws.IS3BucketAnalyticsConfigurationStorageClassAnalysis
    {
        /// <summary>data_export block.</summary>
        [JsiiProperty(name: "dataExport", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport[] DataExport
        {
            get;
            set;
        }
    }
}
