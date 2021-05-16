using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Apigatewayv2AuthorizerJwtConfiguration")]
    public class Apigatewayv2AuthorizerJwtConfiguration : aws.IApigatewayv2AuthorizerJwtConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "audience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Audience
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Issuer
        {
            get;
            set;
        }
    }
}
