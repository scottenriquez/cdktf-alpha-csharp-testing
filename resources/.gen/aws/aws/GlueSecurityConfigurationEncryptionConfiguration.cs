using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueSecurityConfigurationEncryptionConfiguration")]
    public class GlueSecurityConfigurationEncryptionConfiguration : aws.IGlueSecurityConfigurationEncryptionConfiguration
    {
        /// <summary>cloudwatch_encryption block.</summary>
        [JsiiProperty(name: "cloudwatchEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption[] CloudwatchEncryption
        {
            get;
            set;
        }

        /// <summary>job_bookmarks_encryption block.</summary>
        [JsiiProperty(name: "jobBookmarksEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption[] JobBookmarksEncryption
        {
            get;
            set;
        }

        /// <summary>s3_encryption block.</summary>
        [JsiiProperty(name: "s3Encryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption[] S3Encryption
        {
            get;
            set;
        }
    }
}
