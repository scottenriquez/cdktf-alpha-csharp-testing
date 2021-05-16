using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption), fullyQualifiedName: "aws.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption")]
    public interface IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption
    {
        [JsiiProperty(name: "jobBookmarksEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobBookmarksEncryptionMode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption), fullyQualifiedName: "aws.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "jobBookmarksEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobBookmarksEncryptionMode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
