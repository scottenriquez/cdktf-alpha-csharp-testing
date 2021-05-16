using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketInventoryDestinationBucketEncryptionSseKms")]
    public class S3BucketInventoryDestinationBucketEncryptionSseKms : aws.IS3BucketInventoryDestinationBucketEncryptionSseKms
    {
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KeyId
        {
            get;
            set;
        }
    }
}
