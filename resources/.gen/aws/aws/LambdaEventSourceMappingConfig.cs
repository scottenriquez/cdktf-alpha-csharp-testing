using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LambdaEventSourceMappingConfig")]
    public class LambdaEventSourceMappingConfig : aws.ILambdaEventSourceMappingConfig
    {
        [JsiiProperty(name: "eventSourceArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EventSourceArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FunctionName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BatchSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bisectBatchOnFunctionError", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? BisectBatchOnFunctionError
        {
            get;
            set;
        }

        /// <summary>destination_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaEventSourceMappingDestinationConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILambdaEventSourceMappingDestinationConfig[]? DestinationConfig
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

        [JsiiOptional]
        [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumBatchingWindowInSeconds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRecordAgeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumRecordAgeInSeconds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumRetryAttempts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "parallelizationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ParallelizationFactor
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StartingPosition
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "startingPositionTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StartingPositionTimestamp
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
