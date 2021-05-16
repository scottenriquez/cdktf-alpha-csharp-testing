using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterClientAuthenticationTls), fullyQualifiedName: "aws.MskClusterClientAuthenticationTls")]
    public interface IMskClusterClientAuthenticationTls
    {
        [JsiiProperty(name: "certificateAuthorityArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CertificateAuthorityArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterClientAuthenticationTls), fullyQualifiedName: "aws.MskClusterClientAuthenticationTls")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterClientAuthenticationTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthorityArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CertificateAuthorityArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
