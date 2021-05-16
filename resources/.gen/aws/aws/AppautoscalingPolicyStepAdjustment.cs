using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppautoscalingPolicyStepAdjustment")]
    public class AppautoscalingPolicyStepAdjustment : aws.IAppautoscalingPolicyStepAdjustment
    {
        [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ScalingAdjustment
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricIntervalLowerBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MetricIntervalLowerBound
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricIntervalUpperBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MetricIntervalUpperBound
        {
            get;
            set;
        }
    }
}
