using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetConfig), fullyQualifiedName: "aws.CloudwatchEventTargetConfig")]
    public interface ICloudwatchEventTargetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        string Rule
        {
            get;
        }

        /// <summary>batch_target block.</summary>
        [JsiiProperty(name: "batchTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetBatchTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudwatchEventTargetBatchTarget[]? BatchTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecs_target block.</summary>
        [JsiiProperty(name: "ecsTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetEcsTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudwatchEventTargetEcsTarget[]? EcsTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Input
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>input_transformer block.</summary>
        [JsiiProperty(name: "inputTransformer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetInputTransformer\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudwatchEventTargetInputTransformer[]? InputTransformer
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_target block.</summary>
        [JsiiProperty(name: "kinesisTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetKinesisTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudwatchEventTargetKinesisTarget[]? KinesisTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>run_command_targets block.</summary>
        [JsiiProperty(name: "runCommandTargets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudwatchEventTargetRunCommandTargets[]? RunCommandTargets
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs_target block.</summary>
        [JsiiProperty(name: "sqsTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetSqsTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudwatchEventTargetSqsTarget[]? SqsTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetConfig), fullyQualifiedName: "aws.CloudwatchEventTargetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudwatchEventTargetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
            public string Rule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>batch_target block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetBatchTarget\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudwatchEventTargetBatchTarget[]? BatchTarget
            {
                get => GetInstanceProperty<aws.ICloudwatchEventTargetBatchTarget[]?>();
            }

            /// <summary>ecs_target block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ecsTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetEcsTarget\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudwatchEventTargetEcsTarget[]? EcsTarget
            {
                get => GetInstanceProperty<aws.ICloudwatchEventTargetEcsTarget[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Input
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>input_transformer block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputTransformer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetInputTransformer\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudwatchEventTargetInputTransformer[]? InputTransformer
            {
                get => GetInstanceProperty<aws.ICloudwatchEventTargetInputTransformer[]?>();
            }

            /// <summary>kinesis_target block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetKinesisTarget\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudwatchEventTargetKinesisTarget[]? KinesisTarget
            {
                get => GetInstanceProperty<aws.ICloudwatchEventTargetKinesisTarget[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>run_command_targets block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runCommandTargets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudwatchEventTargetRunCommandTargets[]? RunCommandTargets
            {
                get => GetInstanceProperty<aws.ICloudwatchEventTargetRunCommandTargets[]?>();
            }

            /// <summary>sqs_target block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqsTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetSqsTarget\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudwatchEventTargetSqsTarget[]? SqsTarget
            {
                get => GetInstanceProperty<aws.ICloudwatchEventTargetSqsTarget[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
