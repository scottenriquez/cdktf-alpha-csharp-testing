using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ApiGatewayIntegrationConfig")]
    public class ApiGatewayIntegrationConfig : aws.IApiGatewayIntegrationConfig
    {
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HttpMethod
        {
            get;
            set;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ResourceId
        {
            get;
            set;
        }

        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RestApiId
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheKeyParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? CacheKeyParameters
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CacheNamespace
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ConnectionId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ConnectionType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContentHandling
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Credentials
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "integrationHttpMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IntegrationHttpMethod
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "passthroughBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PassthroughBehavior
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? RequestParameters
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestParametersInJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RequestParametersInJson
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? RequestTemplates
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TimeoutMilliseconds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Uri
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
