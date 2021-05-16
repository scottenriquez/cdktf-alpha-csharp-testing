using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration")]
    public class AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration : aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration
    {
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double TargetValue
        {
            get;
            set;
        }

        /// <summary>customized_metric_specification block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification[]? CustomizedMetricSpecification
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableScaleIn", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DisableScaleIn
        {
            get;
            set;
        }

        /// <summary>predefined_metric_specification block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification[]? PredefinedMetricSpecification
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ScaleInCooldown
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ScaleOutCooldown
        {
            get;
            set;
        }
    }
}
