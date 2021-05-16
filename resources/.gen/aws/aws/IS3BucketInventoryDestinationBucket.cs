using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryDestinationBucket), fullyQualifiedName: "aws.S3BucketInventoryDestinationBucket")]
    public interface IS3BucketInventoryDestinationBucket
    {
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        string BucketArn
        {
            get;
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption block.</summary>
        [JsiiProperty(name: "encryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucketEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketInventoryDestinationBucketEncryption[]? Encryption
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryDestinationBucket), fullyQualifiedName: "aws.S3BucketInventoryDestinationBucket")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketInventoryDestinationBucket
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encryption block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucketEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketInventoryDestinationBucketEncryption[]? Encryption
            {
                get => GetInstanceProperty<aws.IS3BucketInventoryDestinationBucketEncryption[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
