using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CognitoUserPoolClientConfig")]
    public class CognitoUserPoolClientConfig : aws.ICognitoUserPoolClientConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPoolId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedOauthFlows", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AllowedOauthFlows
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedOauthFlowsUserPoolClient", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowedOauthFlowsUserPoolClient
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedOauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AllowedOauthScopes
        {
            get;
            set;
        }

        /// <summary>analytics_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "analyticsConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolClientAnalyticsConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolClientAnalyticsConfiguration[]? AnalyticsConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "callbackUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? CallbackUrls
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRedirectUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultRedirectUri
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "explicitAuthFlows", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ExplicitAuthFlows
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "generateSecret", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? GenerateSecret
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoutUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? LogoutUrls
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preventUserExistenceErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreventUserExistenceErrors
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "readAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ReadAttributes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshTokenValidity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RefreshTokenValidity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportedIdentityProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SupportedIdentityProviders
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? WriteAttributes
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
