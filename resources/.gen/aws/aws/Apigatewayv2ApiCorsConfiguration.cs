using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Apigatewayv2ApiCorsConfiguration")]
    public class Apigatewayv2ApiCorsConfiguration : aws.IApigatewayv2ApiCorsConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "allowCredentials", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowCredentials
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AllowHeaders
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AllowMethods
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AllowOrigins
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "exposeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ExposeHeaders
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxAge
        {
            get;
            set;
        }
    }
}
