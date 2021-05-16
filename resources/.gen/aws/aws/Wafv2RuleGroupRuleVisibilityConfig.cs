using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleVisibilityConfig")]
    public class Wafv2RuleGroupRuleVisibilityConfig : aws.IWafv2RuleGroupRuleVisibilityConfig
    {
        [JsiiProperty(name: "cloudwatchMetricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool CloudwatchMetricsEnabled
        {
            get;
            set;
        }

        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MetricName
        {
            get;
            set;
        }

        [JsiiProperty(name: "sampledRequestsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool SampledRequestsEnabled
        {
            get;
            set;
        }
    }
}
