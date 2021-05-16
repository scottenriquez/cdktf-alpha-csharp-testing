using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityRevocationConfiguration), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityRevocationConfiguration")]
    public interface IAcmpcaCertificateAuthorityRevocationConfiguration
    {
        /// <summary>crl_configuration block.</summary>
        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]? CrlConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityRevocationConfiguration), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityRevocationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAcmpcaCertificateAuthorityRevocationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>crl_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crlConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]? CrlConfiguration
            {
                get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration[]?>();
            }
        }
    }
}
