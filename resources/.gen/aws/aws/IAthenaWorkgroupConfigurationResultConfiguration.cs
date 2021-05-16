using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfiguration), fullyQualifiedName: "aws.AthenaWorkgroupConfigurationResultConfiguration")]
    public interface IAthenaWorkgroupConfigurationResultConfiguration
    {
        /// <summary>encryption_configuration block.</summary>
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration[]? EncryptionConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "outputLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationResultConfiguration), fullyQualifiedName: "aws.AthenaWorkgroupConfigurationResultConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAthenaWorkgroupConfigurationResultConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>encryption_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration[]? EncryptionConfiguration
            {
                get => GetInstanceProperty<aws.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "outputLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputLocation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
