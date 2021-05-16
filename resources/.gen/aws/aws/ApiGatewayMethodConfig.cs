using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ApiGatewayMethodConfig")]
    public class ApiGatewayMethodConfig : aws.IApiGatewayMethodConfig
    {
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Authorization
        {
            get;
            set;
        }

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
        [JsiiProperty(name: "authorizerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AuthorizerId
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
        [JsiiProperty(name: "requestParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"boolean\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, bool>? RequestParameters
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
        [JsiiProperty(name: "requestValidatorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RequestValidatorId
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
