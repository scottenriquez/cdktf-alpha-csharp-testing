using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudwatchMetricAlarmConfig")]
    public class CloudwatchMetricAlarmConfig : aws.ICloudwatchMetricAlarmConfig
    {
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AlarmName
        {
            get;
            set;
        }

        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ComparisonOperator
        {
            get;
            set;
        }

        [JsiiProperty(name: "evaluationPeriods", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double EvaluationPeriods
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ActionsEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AlarmActions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AlarmDescription
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datapointsToAlarm", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DatapointsToAlarm
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Dimensions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "evaluateLowSampleCountPercentiles", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EvaluateLowSampleCountPercentiles
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendedStatistic", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ExtendedStatistic
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "insufficientDataActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? InsufficientDataActions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MetricName
        {
            get;
            set;
        }

        /// <summary>metric_query block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricQuery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchMetricAlarmMetricQuery\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudwatchMetricAlarmMetricQuery[]? MetricQuery
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Namespace
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "okActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? OkActions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Period
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "statistic", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Statistic
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Threshold
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdMetricId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ThresholdMetricId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "treatMissingData", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TreatMissingData
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Unit
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
