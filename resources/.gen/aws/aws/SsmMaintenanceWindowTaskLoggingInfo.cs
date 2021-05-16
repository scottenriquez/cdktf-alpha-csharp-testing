using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SsmMaintenanceWindowTaskLoggingInfo")]
    public class SsmMaintenanceWindowTaskLoggingInfo : aws.ISsmMaintenanceWindowTaskLoggingInfo
    {
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3BucketName
        {
            get;
            set;
        }

        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3Region
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3BucketPrefix
        {
            get;
            set;
        }
    }
}
