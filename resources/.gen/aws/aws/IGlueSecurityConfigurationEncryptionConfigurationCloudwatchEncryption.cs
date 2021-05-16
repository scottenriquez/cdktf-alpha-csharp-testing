using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption), fullyQualifiedName: "aws.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption")]
    public interface IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption
    {
        [JsiiProperty(name: "cloudwatchEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchEncryptionMode
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

        [JsiiTypeProxy(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption), fullyQualifiedName: "aws.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchEncryptionMode
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
