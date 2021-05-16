using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventTarget), fullyQualifiedName: "aws.CloudwatchEventTarget", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CloudwatchEventTargetConfig\"}}]")]
    public class CloudwatchEventTarget : HashiCorp.Cdktf.TerraformResource
    {
        public CloudwatchEventTarget(Constructs.Construct scope, string id, aws.ICloudwatchEventTargetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTarget(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTarget(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBatchTarget")]
        public virtual void ResetBatchTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsTarget")]
        public virtual void ResetEcsTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInput")]
        public virtual void ResetInput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputPath")]
        public virtual void ResetInputPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputTransformer")]
        public virtual void ResetInputTransformer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisTarget")]
        public virtual void ResetKinesisTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoleArn")]
        public virtual void ResetRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunCommandTargets")]
        public virtual void ResetRunCommandTargets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqsTarget")]
        public virtual void ResetSqsTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetId")]
        public virtual void ResetTargetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetBatchTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudwatchEventTargetBatchTarget[]? BatchTargetInput
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetBatchTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetEcsTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudwatchEventTargetEcsTarget[]? EcsTargetInput
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetEcsTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputTransformerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetInputTransformer\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudwatchEventTargetInputTransformer[]? InputTransformerInput
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetInputTransformer[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetKinesisTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudwatchEventTargetKinesisTarget[]? KinesisTargetInput
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetKinesisTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runCommandTargetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudwatchEventTargetRunCommandTargets[]? RunCommandTargetsInput
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetRunCommandTargets[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetSqsTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudwatchEventTargetSqsTarget[]? SqsTargetInput
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetSqsTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "batchTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetBatchTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudwatchEventTargetBatchTarget[] BatchTarget
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetBatchTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ecsTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetEcsTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudwatchEventTargetEcsTarget[] EcsTarget
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetEcsTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Input
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputTransformer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetInputTransformer\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudwatchEventTargetInputTransformer[] InputTransformer
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetInputTransformer[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kinesisTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetKinesisTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudwatchEventTargetKinesisTarget[] KinesisTarget
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetKinesisTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runCommandTargets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudwatchEventTargetRunCommandTargets[] RunCommandTargets
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetRunCommandTargets[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqsTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetSqsTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudwatchEventTargetSqsTarget[] SqsTarget
        {
            get => GetInstanceProperty<aws.ICloudwatchEventTargetSqsTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
