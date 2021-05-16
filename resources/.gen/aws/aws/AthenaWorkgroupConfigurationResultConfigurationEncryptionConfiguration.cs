using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration")]
    public class AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration : aws.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EncryptionOption
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
