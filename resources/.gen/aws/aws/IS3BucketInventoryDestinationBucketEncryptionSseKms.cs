using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryptionSseKms), fullyQualifiedName: "aws.S3BucketInventoryDestinationBucketEncryptionSseKms")]
    public interface IS3BucketInventoryDestinationBucketEncryptionSseKms
    {
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryptionSseKms), fullyQualifiedName: "aws.S3BucketInventoryDestinationBucketEncryptionSseKms")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketInventoryDestinationBucketEncryptionSseKms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
