using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingPolicy), fullyQualifiedName: "aws.AutoscalingPolicy", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AutoscalingPolicyConfig\"}}]")]
    public class AutoscalingPolicy : HashiCorp.Cdktf.TerraformResource
    {
        public AutoscalingPolicy(Constructs.Construct scope, string id, aws.IAutoscalingPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdjustmentType")]
        public virtual void ResetAdjustmentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCooldown")]
        public virtual void ResetCooldown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEstimatedInstanceWarmup")]
        public virtual void ResetEstimatedInstanceWarmup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricAggregationType")]
        public virtual void ResetMetricAggregationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinAdjustmentMagnitude")]
        public virtual void ResetMinAdjustmentMagnitude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinAdjustmentStep")]
        public virtual void ResetMinAdjustmentStep()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyType")]
        public virtual void ResetPolicyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalingAdjustment")]
        public virtual void ResetScalingAdjustment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepAdjustment")]
        public virtual void ResetStepAdjustment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetTrackingConfiguration")]
        public virtual void ResetTargetTrackingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoscalingGroupNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoscalingGroupNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adjustmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdjustmentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cooldownInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CooldownInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "estimatedInstanceWarmupInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EstimatedInstanceWarmupInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricAggregationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricAggregationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minAdjustmentMagnitudeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinAdjustmentMagnitudeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minAdjustmentStepInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinAdjustmentStepInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingAdjustmentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScalingAdjustmentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustmentInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAutoscalingPolicyStepAdjustment[]? StepAdjustmentInput
        {
            get => GetInstanceProperty<aws.IAutoscalingPolicyStepAdjustment[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAutoscalingPolicyTargetTrackingConfiguration[]? TargetTrackingConfigurationInput
        {
            get => GetInstanceProperty<aws.IAutoscalingPolicyTargetTrackingConfiguration[]?>();
        }

        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdjustmentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoscalingGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cooldown
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "estimatedInstanceWarmup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EstimatedInstanceWarmup
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricAggregationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAdjustmentMagnitude
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minAdjustmentStep", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAdjustmentStep
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScalingAdjustment
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}")]
        public virtual aws.IAutoscalingPolicyStepAdjustment[] StepAdjustment
        {
            get => GetInstanceProperty<aws.IAutoscalingPolicyStepAdjustment[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IAutoscalingPolicyTargetTrackingConfiguration[] TargetTrackingConfiguration
        {
            get => GetInstanceProperty<aws.IAutoscalingPolicyTargetTrackingConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
