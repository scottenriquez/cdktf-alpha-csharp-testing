using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AppautoscalingPolicy), fullyQualifiedName: "aws.AppautoscalingPolicy", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AppautoscalingPolicyConfig\"}}]")]
    public class AppautoscalingPolicy : HashiCorp.Cdktf.TerraformResource
    {
        public AppautoscalingPolicy(Constructs.Construct scope, string id, aws.IAppautoscalingPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppautoscalingPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppautoscalingPolicy(DeputyProps props): base(props)
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

        [JsiiMethod(name: "resetPolicyType")]
        public virtual void ResetPolicyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepAdjustment")]
        public virtual void ResetStepAdjustment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepScalingPolicyConfiguration")]
        public virtual void ResetStepScalingPolicyConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetTrackingScalingPolicyConfiguration")]
        public virtual void ResetTargetTrackingScalingPolicyConfiguration()
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

        [JsiiProperty(name: "resourceIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scalableDimensionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScalableDimensionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceNamespaceInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNamespaceInput
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
        [JsiiProperty(name: "policyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustmentInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppautoscalingPolicyStepAdjustment[]? StepAdjustmentInput
        {
            get => GetInstanceProperty<aws.IAppautoscalingPolicyStepAdjustment[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepScalingPolicyConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepScalingPolicyConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppautoscalingPolicyStepScalingPolicyConfiguration[]? StepScalingPolicyConfigurationInput
        {
            get => GetInstanceProperty<aws.IAppautoscalingPolicyStepScalingPolicyConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingScalingPolicyConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration[]? TargetTrackingScalingPolicyConfigurationInput
        {
            get => GetInstanceProperty<aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration[]?>();
        }

        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdjustmentType
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

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScalableDimension
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNamespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppautoscalingPolicyStepAdjustment[] StepAdjustment
        {
            get => GetInstanceProperty<aws.IAppautoscalingPolicyStepAdjustment[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepScalingPolicyConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppautoscalingPolicyStepScalingPolicyConfiguration[] StepScalingPolicyConfiguration
        {
            get => GetInstanceProperty<aws.IAppautoscalingPolicyStepScalingPolicyConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration[] TargetTrackingScalingPolicyConfiguration
        {
            get => GetInstanceProperty<aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
