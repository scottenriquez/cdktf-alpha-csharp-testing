using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification), fullyQualifiedName: "aws.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification")]
    public interface IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification
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

        /// <summary>metric_dimension block.</summary>
        [JsiiProperty(name: "metricDimension", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension[]? MetricDimension
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

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification), fullyQualifiedName: "aws.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification
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

            /// <summary>metric_dimension block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricDimension", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension[]? MetricDimension
            {
                get => GetInstanceProperty<aws.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension[]?>();
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
