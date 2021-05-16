using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification")]
    public class AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification : aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
    {
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MetricName
        {
            get;
            set;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Namespace
        {
            get;
            set;
        }

        [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Statistic
        {
            get;
            set;
        }

        /// <summary>dimensions block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions[]? Dimensions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Unit
        {
            get;
            set;
        }
    }
}
