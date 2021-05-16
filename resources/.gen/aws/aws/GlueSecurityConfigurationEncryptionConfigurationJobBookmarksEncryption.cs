using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption")]
    public class GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption : aws.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption
    {
        [JsiiOptional]
        [JsiiProperty(name: "jobBookmarksEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? JobBookmarksEncryptionMode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }
    }
}
