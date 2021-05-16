using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SsmAssociationOutputLocation")]
    public class SsmAssociationOutputLocation : aws.ISsmAssociationOutputLocation
    {
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3BucketName
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
