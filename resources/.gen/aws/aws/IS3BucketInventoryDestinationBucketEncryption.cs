using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryption), fullyQualifiedName: "aws.S3BucketInventoryDestinationBucketEncryption")]
    public interface IS3BucketInventoryDestinationBucketEncryption
    {
        /// <summary>sse_kms block.</summary>
        [JsiiProperty(name: "sseKms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucketEncryptionSseKms\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketInventoryDestinationBucketEncryptionSseKms[]? SseKms
        {
            get
            {
                return null;
            }
        }

        /// <summary>sse_s3 block.</summary>
        [JsiiProperty(name: "sseS3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucketEncryptionSseS3\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketInventoryDestinationBucketEncryptionSseS3[]? SseS3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryption), fullyQualifiedName: "aws.S3BucketInventoryDestinationBucketEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketInventoryDestinationBucketEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sse_kms block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sseKms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucketEncryptionSseKms\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketInventoryDestinationBucketEncryptionSseKms[]? SseKms
            {
                get => GetInstanceProperty<aws.IS3BucketInventoryDestinationBucketEncryptionSseKms[]?>();
            }

            /// <summary>sse_s3 block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sseS3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucketEncryptionSseS3\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketInventoryDestinationBucketEncryptionSseS3[]? SseS3
            {
                get => GetInstanceProperty<aws.IS3BucketInventoryDestinationBucketEncryptionSseS3[]?>();
            }
        }
    }
}
