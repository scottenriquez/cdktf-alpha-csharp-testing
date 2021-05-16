using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration")]
    public interface IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration
    {
        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string KeyAlgorithm
        {
            get;
        }

        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string SigningAlgorithm
        {
            get;
        }

        /// <summary>subject block.</summary>
        [JsiiProperty(name: "subject", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject\"},\"kind\":\"array\"}}")]
        aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject[] Subject
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string SigningAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>subject block.</summary>
            [JsiiProperty(name: "subject", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject\"},\"kind\":\"array\"}}")]
            public aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject[] Subject
            {
                get => GetInstanceProperty<aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject[]>()!;
            }
        }
    }
}
