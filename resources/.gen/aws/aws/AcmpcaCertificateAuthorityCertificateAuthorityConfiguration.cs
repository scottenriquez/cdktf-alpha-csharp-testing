using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration")]
    public class AcmpcaCertificateAuthorityCertificateAuthorityConfiguration : aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration
    {
        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KeyAlgorithm
        {
            get;
            set;
        }

        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SigningAlgorithm
        {
            get;
            set;
        }

        /// <summary>subject block.</summary>
        [JsiiProperty(name: "subject", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject[] Subject
        {
            get;
            set;
        }
    }
}
