using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LbListenerRuleConditionHostHeader")]
    public class LbListenerRuleConditionHostHeader : aws.ILbListenerRuleConditionHostHeader
    {
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
