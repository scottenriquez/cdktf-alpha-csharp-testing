using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfiguration), fullyQualifiedName: "aws.AutoscalingPolicyTargetTrackingConfiguration")]
    public interface IAutoscalingPolicyTargetTrackingConfiguration
    {
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        double TargetValue
        {
            get;
        }

        /// <summary>customized_metric_specification block.</summary>
        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification[]? CustomizedMetricSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "disableScaleIn", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DisableScaleIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>predefined_metric_specification block.</summary>
        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification[]? PredefinedMetricSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyTargetTrackingConfiguration), fullyQualifiedName: "aws.AutoscalingPolicyTargetTrackingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingPolicyTargetTrackingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetValue
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>customized_metric_specification block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification[]? CustomizedMetricSpecification
            {
                get => GetInstanceProperty<aws.IAutoscalingPolicyTargetTrackingConfigurationCustomizedMetricSpecification[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "disableScaleIn", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DisableScaleIn
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>predefined_metric_specification block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification[]? PredefinedMetricSpecification
            {
                get => GetInstanceProperty<aws.IAutoscalingPolicyTargetTrackingConfigurationPredefinedMetricSpecification[]?>();
            }
        }
    }
}
