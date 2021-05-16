using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault), fullyQualifiedName: "aws.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
    public interface IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
    {
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string SseAlgorithm
        {
            get;
        }

        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsMasterKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault), fullyQualifiedName: "aws.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string SseAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsMasterKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
