using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration")]
    public class AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration : aws.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration
    {
        [JsiiProperty(name: "expirationInDays", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ExpirationInDays
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customCname", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomCname
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3BucketName
        {
            get;
            set;
        }
    }
}
