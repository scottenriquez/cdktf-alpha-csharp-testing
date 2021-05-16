using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration")]
    public interface IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration
    {
        [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionOption
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

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionOption
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
