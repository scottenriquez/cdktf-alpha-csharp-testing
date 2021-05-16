using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterClientAuthentication), fullyQualifiedName: "aws.MskClusterClientAuthentication")]
    public interface IMskClusterClientAuthentication
    {
        /// <summary>tls block.</summary>
        [JsiiProperty(name: "tls", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterClientAuthenticationTls\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterClientAuthenticationTls[]? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterClientAuthentication), fullyQualifiedName: "aws.MskClusterClientAuthentication")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterClientAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>tls block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterClientAuthenticationTls\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterClientAuthenticationTls[]? Tls
            {
                get => GetInstanceProperty<aws.IMskClusterClientAuthenticationTls[]?>();
            }
        }
    }
}
