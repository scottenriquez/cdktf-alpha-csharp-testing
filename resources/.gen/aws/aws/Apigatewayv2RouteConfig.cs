using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Apigatewayv2RouteConfig")]
    public class Apigatewayv2RouteConfig : aws.IApigatewayv2RouteConfig
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApiId
        {
            get;
            set;
        }

        [JsiiProperty(name: "routeKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RouteKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeyRequired", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ApiKeyRequired
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AuthorizationScopes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AuthorizationType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AuthorizerId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ModelSelectionExpression
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OperationName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestModels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? RequestModels
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeResponseSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RouteResponseSelectionExpression
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
