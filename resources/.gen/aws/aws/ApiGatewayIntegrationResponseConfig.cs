using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ApiGatewayIntegrationResponseConfig")]
    public class ApiGatewayIntegrationResponseConfig : aws.IApiGatewayIntegrationResponseConfig
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

        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StatusCode
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
        [JsiiProperty(name: "responseParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? ResponseParameters
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseParametersInJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResponseParametersInJson
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? ResponseTemplates
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "selectionPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SelectionPattern
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
