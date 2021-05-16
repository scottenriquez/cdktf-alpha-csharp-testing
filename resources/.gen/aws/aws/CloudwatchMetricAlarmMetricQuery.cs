using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudwatchMetricAlarmMetricQuery")]
    public class CloudwatchMetricAlarmMetricQuery : aws.ICloudwatchMetricAlarmMetricQuery
    {
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Id
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Expression
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>metric block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchMetricAlarmMetricQueryMetric\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudwatchMetricAlarmMetricQueryMetric[]? Metric
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "returnData", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ReturnData
        {
            get;
            set;
        }
    }
}
