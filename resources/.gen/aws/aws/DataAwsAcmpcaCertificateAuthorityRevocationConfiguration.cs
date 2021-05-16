using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DataAwsAcmpcaCertificateAuthorityRevocationConfiguration")]
    public class DataAwsAcmpcaCertificateAuthorityRevocationConfiguration : aws.IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration
    {
        /// <summary>crl_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]? CrlConfiguration
        {
            get;
            set;
        }
    }
}
