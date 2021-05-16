using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.GlueSecurityConfigurationEncryptionConfiguration")]
    public interface IGlueSecurityConfigurationEncryptionConfiguration
    {
        /// <summary>cloudwatch_encryption block.</summary>
        [JsiiProperty(name: "cloudwatchEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"},\"kind\":\"array\"}}")]
        aws.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption[] CloudwatchEncryption
        {
            get;
        }

        /// <summary>job_bookmarks_encryption block.</summary>
        [JsiiProperty(name: "jobBookmarksEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"},\"kind\":\"array\"}}")]
        aws.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption[] JobBookmarksEncryption
        {
            get;
        }

        /// <summary>s3_encryption block.</summary>
        [JsiiProperty(name: "s3Encryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"},\"kind\":\"array\"}}")]
        aws.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption[] S3Encryption
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.GlueSecurityConfigurationEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueSecurityConfigurationEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_encryption block.</summary>
            [JsiiProperty(name: "cloudwatchEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"},\"kind\":\"array\"}}")]
            public aws.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption[] CloudwatchEncryption
            {
                get => GetInstanceProperty<aws.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption[]>()!;
            }

            /// <summary>job_bookmarks_encryption block.</summary>
            [JsiiProperty(name: "jobBookmarksEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"},\"kind\":\"array\"}}")]
            public aws.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption[] JobBookmarksEncryption
            {
                get => GetInstanceProperty<aws.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption[]>()!;
            }

            /// <summary>s3_encryption block.</summary>
            [JsiiProperty(name: "s3Encryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"},\"kind\":\"array\"}}")]
            public aws.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption[] S3Encryption
            {
                get => GetInstanceProperty<aws.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption[]>()!;
            }
        }
    }
}
