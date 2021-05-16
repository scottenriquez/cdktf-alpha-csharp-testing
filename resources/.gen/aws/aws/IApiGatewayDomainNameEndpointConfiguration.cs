using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayDomainNameEndpointConfiguration), fullyQualifiedName: "aws.ApiGatewayDomainNameEndpointConfiguration")]
    public interface IApiGatewayDomainNameEndpointConfiguration
    {
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Types
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayDomainNameEndpointConfiguration), fullyQualifiedName: "aws.ApiGatewayDomainNameEndpointConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayDomainNameEndpointConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Types
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
