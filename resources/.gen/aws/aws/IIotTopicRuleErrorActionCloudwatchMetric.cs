using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionCloudwatchMetric), fullyQualifiedName: "aws.IotTopicRuleErrorActionCloudwatchMetric")]
    public interface IIotTopicRuleErrorActionCloudwatchMetric
    {
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string MetricNamespace
        {
            get;
        }

        [JsiiProperty(name: "metricUnit", typeJson: "{\"primitive\":\"string\"}")]
        string MetricUnit
        {
            get;
        }

        [JsiiProperty(name: "metricValue", typeJson: "{\"primitive\":\"string\"}")]
        string MetricValue
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "metricTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricTimestamp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionCloudwatchMetric), fullyQualifiedName: "aws.IotTopicRuleErrorActionCloudwatchMetric")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleErrorActionCloudwatchMetric
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "metricUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "metricValue", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricValue
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "metricTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricTimestamp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
