using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyStepScalingPolicyConfiguration), fullyQualifiedName: "aws.AppautoscalingPolicyStepScalingPolicyConfiguration")]
    public interface IAppautoscalingPolicyStepScalingPolicyConfiguration
    {
        [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdjustmentType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cooldown
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricAggregationType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinAdjustmentMagnitude
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_adjustment block.</summary>
        [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment[]? StepAdjustment
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyStepScalingPolicyConfiguration), fullyQualifiedName: "aws.AppautoscalingPolicyStepScalingPolicyConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAppautoscalingPolicyStepScalingPolicyConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "adjustmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdjustmentType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cooldown
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "metricAggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricAggregationType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minAdjustmentMagnitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinAdjustmentMagnitude
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>step_adjustment block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepAdjustment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment[]? StepAdjustment
            {
                get => GetInstanceProperty<aws.IAppautoscalingPolicyStepScalingPolicyConfigurationStepAdjustment[]?>();
            }
        }
    }
}
