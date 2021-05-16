using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Apigatewayv2ApiConfig")]
    public class Apigatewayv2ApiConfig : aws.IApigatewayv2ApiConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ProtocolType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeySelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ApiKeySelectionExpression
        {
            get;
            set;
        }

        /// <summary>cors_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "corsConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2ApiCorsConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IApigatewayv2ApiCorsConfiguration[]? CorsConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CredentialsArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RouteKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RouteSelectionExpression
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Target
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Version
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
