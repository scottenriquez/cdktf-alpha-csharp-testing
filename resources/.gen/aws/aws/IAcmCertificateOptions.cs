using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAcmCertificateOptions), fullyQualifiedName: "aws.AcmCertificateOptions")]
    public interface IAcmCertificateOptions
    {
        [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateTransparencyLoggingPreference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmCertificateOptions), fullyQualifiedName: "aws.AcmCertificateOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IAcmCertificateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateTransparencyLoggingPreference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
