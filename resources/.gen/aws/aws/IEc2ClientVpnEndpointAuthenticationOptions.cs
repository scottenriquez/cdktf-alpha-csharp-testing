using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2ClientVpnEndpointAuthenticationOptions), fullyQualifiedName: "aws.Ec2ClientVpnEndpointAuthenticationOptions")]
    public interface IEc2ClientVpnEndpointAuthenticationOptions
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "activeDirectoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActiveDirectoryId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rootCertificateChainArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootCertificateChainArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2ClientVpnEndpointAuthenticationOptions), fullyQualifiedName: "aws.Ec2ClientVpnEndpointAuthenticationOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2ClientVpnEndpointAuthenticationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "activeDirectoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActiveDirectoryId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rootCertificateChainArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootCertificateChainArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
