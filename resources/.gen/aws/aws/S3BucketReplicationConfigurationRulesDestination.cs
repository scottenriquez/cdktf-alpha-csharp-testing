using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketReplicationConfigurationRulesDestination")]
    public class S3BucketReplicationConfigurationRulesDestination : aws.IS3BucketReplicationConfigurationRulesDestination
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>access_control_translation block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation[]? AccessControlTranslation
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

        [JsiiOptional]
        [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReplicaKmsKeyId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StorageClass
        {
            get;
            set;
        }
    }
}
