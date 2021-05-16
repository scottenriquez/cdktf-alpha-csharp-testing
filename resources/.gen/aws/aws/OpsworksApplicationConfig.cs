using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.OpsworksApplicationConfig")]
    public class OpsworksApplicationConfig : aws.IOpsworksApplicationConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StackId
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

        /// <summary>app_source block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationAppSource\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IOpsworksApplicationAppSource[]? AppSource
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoBundleOnDeploy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AutoBundleOnDeploy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsFlowRubySettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AwsFlowRubySettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DataSourceArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DataSourceDatabaseName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DataSourceType
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
        [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DocumentRoot
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Domains
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableSsl", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnableSsl
        {
            get;
            set;
        }

        /// <summary>environment block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationEnvironment\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IOpsworksApplicationEnvironment[]? Environment
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "railsEnv", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RailsEnv
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ShortName
        {
            get;
            set;
        }

        /// <summary>ssl_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationSslConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IOpsworksApplicationSslConfiguration[]? SslConfiguration
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
