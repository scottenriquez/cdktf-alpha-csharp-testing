using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationS3Encryption), fullyQualifiedName: "aws.GlueSecurityConfigurationEncryptionConfigurationS3Encryption")]
    public interface IGlueSecurityConfigurationEncryptionConfigurationS3Encryption
    {
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "s3EncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3EncryptionMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationS3Encryption), fullyQualifiedName: "aws.GlueSecurityConfigurationEncryptionConfigurationS3Encryption")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3EncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3EncryptionMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
