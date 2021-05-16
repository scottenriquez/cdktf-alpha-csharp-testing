using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketServerSideEncryptionConfiguration), fullyQualifiedName: "aws.S3BucketServerSideEncryptionConfiguration")]
    public interface IS3BucketServerSideEncryptionConfiguration
    {
        /// <summary>rule block.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfigurationRule\"},\"kind\":\"array\"}}")]
        aws.IS3BucketServerSideEncryptionConfigurationRule[] Rule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketServerSideEncryptionConfiguration), fullyQualifiedName: "aws.S3BucketServerSideEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketServerSideEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rule block.</summary>
            [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfigurationRule\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketServerSideEncryptionConfigurationRule[] Rule
            {
                get => GetInstanceProperty<aws.IS3BucketServerSideEncryptionConfigurationRule[]>()!;
            }
        }
    }
}
