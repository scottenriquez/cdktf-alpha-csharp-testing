using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudwatchEventTargetConfig")]
    public class CloudwatchEventTargetConfig : aws.ICloudwatchEventTargetConfig
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Arn
        {
            get;
            set;
        }

        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Rule
        {
            get;
            set;
        }

        /// <summary>batch_target block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetBatchTarget\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudwatchEventTargetBatchTarget[]? BatchTarget
        {
            get;
            set;
        }

        /// <summary>ecs_target block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ecsTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetEcsTarget\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudwatchEventTargetEcsTarget[]? EcsTarget
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Input
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InputPath
        {
            get;
            set;
        }

        /// <summary>input_transformer block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputTransformer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetInputTransformer\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudwatchEventTargetInputTransformer[]? InputTransformer
        {
            get;
            set;
        }

        /// <summary>kinesis_target block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetKinesisTarget\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudwatchEventTargetKinesisTarget[]? KinesisTarget
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RoleArn
        {
            get;
            set;
        }

        /// <summary>run_command_targets block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runCommandTargets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudwatchEventTargetRunCommandTargets[]? RunCommandTargets
        {
            get;
            set;
        }

        /// <summary>sqs_target block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqsTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetSqsTarget\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudwatchEventTargetSqsTarget[]? SqsTarget
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TargetId
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
