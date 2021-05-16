using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppsyncGraphqlApiConfig")]
    public class AppsyncGraphqlApiConfig : aws.IAppsyncGraphqlApiConfig
    {
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AuthenticationType
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

        /// <summary>additional_authentication_provider block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalAuthenticationProvider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider[]? AdditionalAuthenticationProvider
        {
            get;
            set;
        }

        /// <summary>log_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiLogConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncGraphqlApiLogConfig[]? LogConfig
        {
            get;
            set;
        }

        /// <summary>openid_connect_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiOpenidConnectConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncGraphqlApiOpenidConnectConfig[]? OpenidConnectConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Schema
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

        /// <summary>user_pool_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiUserPoolConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncGraphqlApiUserPoolConfig[]? UserPoolConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "xrayEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? XrayEnabled
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
