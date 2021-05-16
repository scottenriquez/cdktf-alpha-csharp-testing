using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteria")]
    public class S3BucketReplicationConfigurationRulesSourceSelectionCriteria : aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria
    {
        /// <summary>sse_kms_encrypted_objects block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects[]? SseKmsEncryptedObjects
        {
            get;
            set;
        }
    }
}
