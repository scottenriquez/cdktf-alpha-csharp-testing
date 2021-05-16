using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionViewerCertificate), fullyQualifiedName: "aws.CloudfrontDistributionViewerCertificate")]
    public interface ICloudfrontDistributionViewerCertificate
    {
        [JsiiProperty(name: "acmCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AcmCertificateArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cloudfrontDefaultCertificate", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? CloudfrontDefaultCertificate
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "iamCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamCertificateId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minimumProtocolVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumProtocolVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sslSupportMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslSupportMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionViewerCertificate), fullyQualifiedName: "aws.CloudfrontDistributionViewerCertificate")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionViewerCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "acmCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AcmCertificateArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cloudfrontDefaultCertificate", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? CloudfrontDefaultCertificate
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "iamCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamCertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minimumProtocolVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumProtocolVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sslSupportMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslSupportMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
