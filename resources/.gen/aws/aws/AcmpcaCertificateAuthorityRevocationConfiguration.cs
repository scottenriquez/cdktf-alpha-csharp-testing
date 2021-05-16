using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AcmpcaCertificateAuthorityRevocationConfiguration")]
    public class AcmpcaCertificateAuthorityRevocationConfiguration : aws.IAcmpcaCertificateAuthorityRevocationConfiguration
    {
        /// <summary>crl_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]? CrlConfiguration
        {
            get;
            set;
        }
    }
}
