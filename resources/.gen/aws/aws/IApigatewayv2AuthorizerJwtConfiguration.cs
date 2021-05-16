using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2AuthorizerJwtConfiguration), fullyQualifiedName: "aws.Apigatewayv2AuthorizerJwtConfiguration")]
    public interface IApigatewayv2AuthorizerJwtConfiguration
    {
        [JsiiProperty(name: "audience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Audience
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Issuer
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2AuthorizerJwtConfiguration), fullyQualifiedName: "aws.Apigatewayv2AuthorizerJwtConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IApigatewayv2AuthorizerJwtConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "audience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Audience
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Issuer
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
