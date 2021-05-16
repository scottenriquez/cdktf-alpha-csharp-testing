using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupVisibilityConfig), fullyQualifiedName: "aws.Wafv2RuleGroupVisibilityConfig")]
    public interface IWafv2RuleGroupVisibilityConfig
    {
        [JsiiProperty(name: "cloudwatchMetricsEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool CloudwatchMetricsEnabled
        {
            get;
        }

        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        [JsiiProperty(name: "sampledRequestsEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool SampledRequestsEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupVisibilityConfig), fullyQualifiedName: "aws.Wafv2RuleGroupVisibilityConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupVisibilityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "cloudwatchMetricsEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool CloudwatchMetricsEnabled
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sampledRequestsEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool SampledRequestsEnabled
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}
