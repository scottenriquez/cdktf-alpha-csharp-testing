using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Apigatewayv2IntegrationConfig")]
    public class Apigatewayv2IntegrationConfig : aws.IApigatewayv2IntegrationConfig
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApiId
        {
            get;
            set;
        }

        [JsiiProperty(name: "integrationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IntegrationType
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
        [JsiiProperty(name: "contentHandlingStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContentHandlingStrategy
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
        [JsiiProperty(name: "integrationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IntegrationMethod
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "integrationUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IntegrationUri
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
        [JsiiProperty(name: "payloadFormatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PayloadFormatVersion
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
        [JsiiProperty(name: "templateSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TemplateSelectionExpression
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
