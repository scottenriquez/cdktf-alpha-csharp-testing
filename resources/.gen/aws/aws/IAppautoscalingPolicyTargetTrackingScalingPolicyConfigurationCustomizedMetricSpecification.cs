using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification), fullyQualifiedName: "aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification")]
    public interface IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
    {
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}")]
        string Statistic
        {
            get;
        }

        /// <summary>dimensions block.</summary>
        [JsiiProperty(name: "dimensions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions[]? Dimensions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Unit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification), fullyQualifiedName: "aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}")]
            public string Statistic
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>dimensions block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions[]? Dimensions
            {
                get => GetInstanceProperty<aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Unit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
