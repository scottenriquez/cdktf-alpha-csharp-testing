using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration")]
    public interface IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration
    {
        [JsiiProperty(name: "expirationInDays", typeJson: "{\"primitive\":\"number\"}")]
        double ExpirationInDays
        {
            get;
        }

        [JsiiProperty(name: "customCname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomCname
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BucketName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration), fullyQualifiedName: "aws.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "expirationInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double ExpirationInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "customCname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomCname
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BucketName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
