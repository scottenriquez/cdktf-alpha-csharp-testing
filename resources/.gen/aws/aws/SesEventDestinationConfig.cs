using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SesEventDestinationConfig")]
    public class SesEventDestinationConfig : aws.ISesEventDestinationConfig
    {
        [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ConfigurationSetName
        {
            get;
            set;
        }

        [JsiiProperty(name: "matchingTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] MatchingTypes
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

        /// <summary>cloudwatch_destination block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesEventDestinationCloudwatchDestination[]? CloudwatchDestination
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary>kinesis_destination block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationKinesisDestination\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesEventDestinationKinesisDestination[]? KinesisDestination
        {
            get;
            set;
        }

        /// <summary>sns_destination block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snsDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationSnsDestination\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesEventDestinationSnsDestination[]? SnsDestination
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
