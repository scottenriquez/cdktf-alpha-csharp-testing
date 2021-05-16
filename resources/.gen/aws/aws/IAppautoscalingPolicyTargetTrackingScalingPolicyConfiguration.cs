using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration), fullyQualifiedName: "aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration")]
    public interface IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration
    {
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        double TargetValue
        {
            get;
        }

        /// <summary>customized_metric_specification block.</summary>
        [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification[]? CustomizedMetricSpecification
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
        [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification[]? PredefinedMetricSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleInCooldown
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleOutCooldown
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration), fullyQualifiedName: "aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration
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
            [JsiiProperty(name: "customizedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification[]? CustomizedMetricSpecification
            {
                get => GetInstanceProperty<aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "disableScaleIn", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DisableScaleIn
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>predefined_metric_specification block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedMetricSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification[]? PredefinedMetricSpecification
            {
                get => GetInstanceProperty<aws.IAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleInCooldown
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleOutCooldown
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
