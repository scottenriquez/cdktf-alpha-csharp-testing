using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AutoscalingPolicyTargetTrackingConfiguration")]
    public class AutoscalingPolicyTargetTrackingConfiguration : aws.IAutoscalingPolicyTargetTrackingConfiguration
    {
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double TargetValue
        {
            get;
            set;
        }

        /// <summary>customized_metric_specification block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification[]? CustomizedMetricSpecification
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
        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification[]? PredefinedMetricSpecification
        {
            get;
            set;
        }
    }
}
