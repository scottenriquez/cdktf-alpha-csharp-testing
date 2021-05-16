using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyConfig), fullyQualifiedName: "aws.AutoscalingPolicyConfig")]
    public interface IAutoscalingPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string AutoscalingGroupName
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdjustmentType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cooldown
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "estimatedInstanceWarmup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EstimatedInstanceWarmup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricAggregationType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinAdjustmentMagnitude
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minAdjustmentStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinAdjustmentStep
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScalingAdjustment
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_adjustment block.</summary>
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAutoscalingPolicyStepAdjustment[]? StepAdjustment
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_tracking_configuration block.</summary>
        [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAutoscalingPolicyTargetTrackingConfiguration[]? TargetTrackingConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyConfig), fullyQualifiedName: "aws.AutoscalingPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string AutoscalingGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdjustmentType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cooldown
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "estimatedInstanceWarmup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EstimatedInstanceWarmup
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricAggregationType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinAdjustmentMagnitude
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minAdjustmentStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinAdjustmentStep
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScalingAdjustment
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>step_adjustment block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAutoscalingPolicyStepAdjustment[]? StepAdjustment
            {
                get => GetInstanceProperty<aws.IAutoscalingPolicyStepAdjustment[]?>();
            }

            /// <summary>target_tracking_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAutoscalingPolicyTargetTrackingConfiguration[]? TargetTrackingConfiguration
            {
                get => GetInstanceProperty<aws.IAutoscalingPolicyTargetTrackingConfiguration[]?>();
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
