using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueSecurityConfigurationEncryptionConfigurationS3Encryption")]
    public class GlueSecurityConfigurationEncryptionConfigurationS3Encryption : aws.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption
    {
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3EncryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3EncryptionMode
        {
            get;
            set;
        }
    }
}
