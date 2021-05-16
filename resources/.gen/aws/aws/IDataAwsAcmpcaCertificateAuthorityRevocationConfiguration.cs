using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration), fullyQualifiedName: "aws.DataAwsAcmpcaCertificateAuthorityRevocationConfiguration")]
    public interface IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration
    {
        /// <summary>crl_configuration block.</summary>
        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]? CrlConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration), fullyQualifiedName: "aws.DataAwsAcmpcaCertificateAuthorityRevocationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsAcmpcaCertificateAuthorityRevocationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>crl_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crlConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]? CrlConfiguration
            {
                get => GetInstanceProperty<aws.IDataAwsAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]?>();
            }
        }
    }
}
