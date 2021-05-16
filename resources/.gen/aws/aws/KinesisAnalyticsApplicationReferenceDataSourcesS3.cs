using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationReferenceDataSourcesS3")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesS3 : aws.IKinesisAnalyticsApplicationReferenceDataSourcesS3
    {
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BucketArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "fileKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FileKey
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }
    }
}
