using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment), fullyQualifiedName: "aws.AppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment")]
    public interface IAppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment
    {
        [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}")]
        double ScalingAdjustment
        {
            get;
        }

        [JsiiProperty(name: "metricIntervalLowerBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricIntervalLowerBound
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "metricIntervalUpperBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricIntervalUpperBound
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment), fullyQualifiedName: "aws.AppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment")]
        internal sealed class _Proxy : DeputyBase, aws.IAppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "scalingAdjustment", typeJson: "{\"primitive\":\"number\"}")]
            public double ScalingAdjustment
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "metricIntervalLowerBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricIntervalLowerBound
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "metricIntervalUpperBound", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricIntervalUpperBound
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
