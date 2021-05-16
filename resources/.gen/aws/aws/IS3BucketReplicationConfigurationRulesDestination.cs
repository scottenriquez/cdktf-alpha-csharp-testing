using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRulesDestination), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRulesDestination")]
    public interface IS3BucketReplicationConfigurationRulesDestination
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>access_control_translation block.</summary>
        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation[]? AccessControlTranslation
        {
            get
            {
                return null;
            }
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

        [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicaKmsKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageClass
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRulesDestination), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRulesDestination")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketReplicationConfigurationRulesDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>access_control_translation block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation[]? AccessControlTranslation
            {
                get => GetInstanceProperty<aws.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicaKmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageClass
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
