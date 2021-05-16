using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2DomainNameDomainNameConfiguration), fullyQualifiedName: "aws.Apigatewayv2DomainNameDomainNameConfiguration")]
    public interface IApigatewayv2DomainNameDomainNameConfiguration
    {
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateArn
        {
            get;
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointType
        {
            get;
        }

        [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string SecurityPolicy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2DomainNameDomainNameConfiguration), fullyQualifiedName: "aws.Apigatewayv2DomainNameDomainNameConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IApigatewayv2DomainNameDomainNameConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string SecurityPolicy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
