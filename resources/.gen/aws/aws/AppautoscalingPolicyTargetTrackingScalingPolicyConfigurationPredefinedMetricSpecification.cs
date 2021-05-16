using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification")]
    public class AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification : aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
    {
        [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PredefinedMetricType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResourceLabel
        {
            get;
            set;
        }
    }
}
