using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption")]
    public class GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption : aws.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption
    {
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchEncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CloudwatchEncryptionMode
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
