using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyConfig), fullyQualifiedName: "aws.AppautoscalingPolicyConfig")]
    public interface IAppautoscalingPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
        string ScalableDimension
        {
            get;
        }

        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceNamespace
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

        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_adjustment block.</summary>
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppautoscalingPolicyStepAdjustment[]? StepAdjustment
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_scaling_policy_configuration block.</summary>
        [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepScalingPolicyConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppautoscalingPolicyStepScalingPolicyConfiguration[]? StepScalingPolicyConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_tracking_scaling_policy_configuration block.</summary>
        [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration[]? TargetTrackingScalingPolicyConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyConfig), fullyQualifiedName: "aws.AppautoscalingPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppautoscalingPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
            public string ScalableDimension
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceNamespace
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
            [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>step_adjustment block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppautoscalingPolicyStepAdjustment[]? StepAdjustment
            {
                get => GetInstanceProperty<aws.IAppautoscalingPolicyStepAdjustment[]?>();
            }

            /// <summary>step_scaling_policy_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepScalingPolicyConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppautoscalingPolicyStepScalingPolicyConfiguration[]? StepScalingPolicyConfiguration
            {
                get => GetInstanceProperty<aws.IAppautoscalingPolicyStepScalingPolicyConfiguration[]?>();
            }

            /// <summary>target_tracking_scaling_policy_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration[]? TargetTrackingScalingPolicyConfiguration
            {
                get => GetInstanceProperty<aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration[]?>();
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
