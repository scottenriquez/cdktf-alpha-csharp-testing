using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricAlarmMetricQuery), fullyQualifiedName: "aws.CloudwatchMetricAlarmMetricQuery")]
    public interface ICloudwatchMetricAlarmMetricQuery
    {
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric block.</summary>
        [JsiiProperty(name: "metric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchMetricAlarmMetricQueryMetric\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudwatchMetricAlarmMetricQueryMetric[]? Metric
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "returnData", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ReturnData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricAlarmMetricQuery), fullyQualifiedName: "aws.CloudwatchMetricAlarmMetricQuery")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudwatchMetricAlarmMetricQuery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metric block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchMetricAlarmMetricQueryMetric\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudwatchMetricAlarmMetricQueryMetric[]? Metric
            {
                get => GetInstanceProperty<aws.ICloudwatchMetricAlarmMetricQueryMetric[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "returnData", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReturnData
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
