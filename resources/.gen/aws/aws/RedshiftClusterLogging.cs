using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.RedshiftClusterLogging")]
    public class RedshiftClusterLogging : aws.IRedshiftClusterLogging
    {
        [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Enable
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BucketName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3KeyPrefix
        {
            get;
            set;
        }
    }
}
