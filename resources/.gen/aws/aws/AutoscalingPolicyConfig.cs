using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AutoscalingPolicyConfig")]
    public class AutoscalingPolicyConfig : aws.IAutoscalingPolicyConfig
    {
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AutoscalingGroupName
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
        [JsiiProperty(name: "estimatedInstanceWarmup", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? EstimatedInstanceWarmup
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
        [JsiiProperty(name: "minAdjustmentStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinAdjustmentStep
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

        [JsiiOptional]
        [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ScalingAdjustment
        {
            get;
            set;
        }

        /// <summary>step_adjustment block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingPolicyStepAdjustment[]? StepAdjustment
        {
            get;
            set;
        }

        /// <summary>target_tracking_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingPolicyTargetTrackingConfiguration[]? TargetTrackingConfiguration
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
