using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ApiGatewayUsagePlanConfig")]
    public class ApiGatewayUsagePlanConfig : aws.IApiGatewayUsagePlanConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>api_stages block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "apiStages", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayUsagePlanApiStages\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IApiGatewayUsagePlanApiStages[]? ApiStages
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
        [JsiiProperty(name: "productCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ProductCode
        {
            get;
            set;
        }

        /// <summary>quota_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "quotaSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayUsagePlanQuotaSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IApiGatewayUsagePlanQuotaSettings[]? QuotaSettings
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

        /// <summary>throttle_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "throttleSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayUsagePlanThrottleSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IApiGatewayUsagePlanThrottleSettings[]? ThrottleSettings
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
