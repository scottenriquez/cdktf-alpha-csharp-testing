using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRule), fullyQualifiedName: "aws.S3BucketServerSideEncryptionConfigurationRule")]
    public interface IS3BucketServerSideEncryptionConfigurationRule
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"},\"kind\":\"array\"}}")]
        aws.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault[] ApplyServerSideEncryptionByDefault
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRule), fullyQualifiedName: "aws.S3BucketServerSideEncryptionConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketServerSideEncryptionConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>apply_server_side_encryption_by_default block.</summary>
            [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault[] ApplyServerSideEncryptionByDefault
            {
                get => GetInstanceProperty<aws.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault[]>()!;
            }
        }
    }
}
