using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleCreateRule : aws.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule
    {
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Interval
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IntervalUnit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "times", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Times
        {
            get;
            set;
        }
    }
}
