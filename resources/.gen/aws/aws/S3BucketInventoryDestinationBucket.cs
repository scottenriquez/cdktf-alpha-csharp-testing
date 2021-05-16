using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketInventoryDestinationBucket")]
    public class S3BucketInventoryDestinationBucket : aws.IS3BucketInventoryDestinationBucket
    {
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BucketArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Format
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AccountId
        {
            get;
            set;
        }

        /// <summary>encryption block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucketEncryption\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketInventoryDestinationBucketEncryption[]? Encryption
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
