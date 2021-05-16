using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Apigatewayv2StageConfig")]
    public class Apigatewayv2StageConfig : aws.IApigatewayv2StageConfig
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApiId
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>access_log_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessLogSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageAccessLogSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IApigatewayv2StageAccessLogSettings[]? AccessLogSettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoDeploy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AutoDeploy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ClientCertificateId
        {
            get;
            set;
        }

        /// <summary>default_route_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultRouteSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageDefaultRouteSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IApigatewayv2StageDefaultRouteSettings[]? DefaultRouteSettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeploymentId
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

        /// <summary>route_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routeSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageRouteSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IApigatewayv2StageRouteSettings[]? RouteSettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? StageVariables
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
