using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityTimeouts), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityTimeouts")]
    public interface IAcmpcaCertificateAuthorityTimeouts
    {
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityTimeouts), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.IAcmpcaCertificateAuthorityTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
