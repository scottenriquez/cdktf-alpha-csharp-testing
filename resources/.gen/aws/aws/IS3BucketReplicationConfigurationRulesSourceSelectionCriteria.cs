using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRulesSourceSelectionCriteria), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteria")]
    public interface IS3BucketReplicationConfigurationRulesSourceSelectionCriteria
    {
        /// <summary>sse_kms_encrypted_objects block.</summary>
        [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects[]? SseKmsEncryptedObjects
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRulesSourceSelectionCriteria), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sse_kms_encrypted_objects block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects[]? SseKmsEncryptedObjects
            {
                get => GetInstanceProperty<aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects[]?>();
            }
        }
    }
}
