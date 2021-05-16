using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DatasyncLocationS3S3Config")]
    public class DatasyncLocationS3S3Config : aws.IDatasyncLocationS3S3Config
    {
        [JsiiProperty(name: "bucketAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BucketAccessRoleArn
        {
            get;
            set;
        }
    }
}
