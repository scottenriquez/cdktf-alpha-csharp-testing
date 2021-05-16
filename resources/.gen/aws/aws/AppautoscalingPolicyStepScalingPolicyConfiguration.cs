using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppautoscalingPolicyStepScalingPolicyConfiguration")]
    public class AppautoscalingPolicyStepScalingPolicyConfiguration : aws.IAppautoscalingPolicyStepScalingPolicyConfiguration
    {
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

        /// <summary>step_adjustment block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment[]? StepAdjustment
        {
            get;
            set;
        }
    }
}
