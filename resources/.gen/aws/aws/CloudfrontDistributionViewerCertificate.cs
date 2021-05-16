using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CloudfrontDistributionViewerCertificate")]
    public class CloudfrontDistributionViewerCertificate : aws.ICloudfrontDistributionViewerCertificate
    {
        [JsiiOptional]
        [JsiiProperty(name: "acmCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AcmCertificateArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudfrontDefaultCertificate", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? CloudfrontDefaultCertificate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IamCertificateId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumProtocolVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MinimumProtocolVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslSupportMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SslSupportMethod
        {
            get;
            set;
        }
    }
}
