using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationConfig")]
    public class KinesisAnalyticsApplicationConfig : aws.IKinesisAnalyticsApplicationConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Code
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

        /// <summary>inputs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputs[]? Inputs
        {
            get;
            set;
        }

        /// <summary>outputs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationOutputs[]? Outputs
        {
            get;
            set;
        }

        /// <summary>reference_data_sources block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "referenceDataSources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSources\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationReferenceDataSources[]? ReferenceDataSources
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