using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppautoscalingPolicyConfig")]
    public class AppautoscalingPolicyConfig : aws.IAppautoscalingPolicyConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ResourceId
        {
            get;
            set;
        }

        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ScalableDimension
        {
            get;
            set;
        }

        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceNamespace
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AdjustmentType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Cooldown
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MetricAggregationType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinAdjustmentMagnitude
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PolicyType
        {
            get;
            set;
        }

        /// <summary>step_adjustment block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppautoscalingPolicyStepAdjustment[]? StepAdjustment
        {
            get;
            set;
        }

        /// <summary>step_scaling_policy_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepScalingPolicyConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppautoscalingPolicyStepScalingPolicyConfiguration[]? StepScalingPolicyConfiguration
        {
            get;
            set;
        }

        /// <summary>target_tracking_scaling_policy_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration[]? TargetTrackingScalingPolicyConfiguration
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
