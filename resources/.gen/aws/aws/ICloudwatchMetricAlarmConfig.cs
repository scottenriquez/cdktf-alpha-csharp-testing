using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricAlarmConfig), fullyQualifiedName: "aws.CloudwatchMetricAlarmConfig")]
    public interface ICloudwatchMetricAlarmConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
        string AlarmName
        {
            get;
        }

        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ComparisonOperator
        {
            get;
        }

        [JsiiProperty(name: "evaluationPeriods", typeJson: "{\"primitive\":\"number\"}")]
        double EvaluationPeriods
        {
            get;
        }

        [JsiiProperty(name: "actionsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ActionsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "alarmActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AlarmActions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "alarmDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AlarmDescription
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "datapointsToAlarm", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DatapointsToAlarm
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Dimensions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "evaluateLowSampleCountPercentiles", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EvaluateLowSampleCountPercentiles
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "extendedStatistic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExtendedStatistic
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "insufficientDataActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InsufficientDataActions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricName
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric_query block.</summary>
        [JsiiProperty(name: "metricQuery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchMetricAlarmMetricQuery\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudwatchMetricAlarmMetricQuery[]? MetricQuery
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "okActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OkActions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Period
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Statistic
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Threshold
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "thresholdMetricId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ThresholdMetricId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "treatMissingData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TreatMissingData
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

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricAlarmConfig), fullyQualifiedName: "aws.CloudwatchMetricAlarmConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudwatchMetricAlarmConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
            public string AlarmName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ComparisonOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "evaluationPeriods", typeJson: "{\"primitive\":\"number\"}")]
            public double EvaluationPeriods
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "actionsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ActionsEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "alarmActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AlarmActions
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "alarmDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AlarmDescription
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "datapointsToAlarm", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DatapointsToAlarm
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Dimensions
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "evaluateLowSampleCountPercentiles", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EvaluateLowSampleCountPercentiles
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "extendedStatistic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExtendedStatistic
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "insufficientDataActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InsufficientDataActions
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metric_query block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricQuery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchMetricAlarmMetricQuery\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudwatchMetricAlarmMetricQuery[]? MetricQuery
            {
                get => GetInstanceProperty<aws.ICloudwatchMetricAlarmMetricQuery[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "okActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OkActions
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Period
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Statistic
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Threshold
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "thresholdMetricId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ThresholdMetricId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "treatMissingData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TreatMissingData
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Unit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
