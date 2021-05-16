using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.S3BucketInventoryDestinationBucketEncryption")]
    public class S3BucketInventoryDestinationBucketEncryption : aws.IS3BucketInventoryDestinationBucketEncryption
    {
        /// <summary>sse_kms block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sseKms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucketEncryptionSseKms\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketInventoryDestinationBucketEncryptionSseKms[]? SseKms
        {
            get;
            set;
        }

        /// <summary>sse_s3 block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sseS3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucketEncryptionSseS3\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketInventoryDestinationBucketEncryptionSseS3[]? SseS3
        {
            get;
            set;
        }
    }
}
