using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification), fullyQualifiedName: "aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification")]
    public interface IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
    {
        [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}")]
        string PredefinedMetricType
        {
            get;
        }

        [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceLabel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification), fullyQualifiedName: "aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "predefinedMetricType", typeJson: "{\"primitive\":\"string\"}")]
            public string PredefinedMetricType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceLabel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
