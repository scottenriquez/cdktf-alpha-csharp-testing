using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AcmCertificateOptions")]
    public class AcmCertificateOptions : aws.IAcmCertificateOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CertificateTransparencyLoggingPreference
        {
            get;
            set;
        }
    }
}
