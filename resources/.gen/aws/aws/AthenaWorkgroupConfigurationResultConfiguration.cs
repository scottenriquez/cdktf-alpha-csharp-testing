using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AthenaWorkgroupConfigurationResultConfiguration")]
    public class AthenaWorkgroupConfigurationResultConfiguration : aws.IAthenaWorkgroupConfigurationResultConfiguration
    {
        /// <summary>encryption_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration[]? EncryptionConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OutputLocation
        {
            get;
            set;
        }
    }
}
