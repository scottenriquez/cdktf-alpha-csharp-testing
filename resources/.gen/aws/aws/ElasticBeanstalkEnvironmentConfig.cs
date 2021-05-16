using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticBeanstalkEnvironmentConfig")]
    public class ElasticBeanstalkEnvironmentConfig : aws.IElasticBeanstalkEnvironmentConfig
    {
        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Application
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

        [JsiiOptional]
        [JsiiProperty(name: "cnamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CnamePrefix
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
        [JsiiProperty(name: "platformArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PlatformArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pollInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PollInterval
        {
            get;
            set;
        }

        /// <summary>setting block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "setting", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticBeanstalkEnvironmentSetting\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticBeanstalkEnvironmentSetting[]? Setting
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "solutionStackName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SolutionStackName
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

        [JsiiOptional]
        [JsiiProperty(name: "templateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TemplateName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Tier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VersionLabel
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForReadyTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WaitForReadyTimeout
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
