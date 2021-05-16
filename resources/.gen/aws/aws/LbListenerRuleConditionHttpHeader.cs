using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LbListenerRuleConditionHttpHeader")]
    public class LbListenerRuleConditionHttpHeader : aws.ILbListenerRuleConditionHttpHeader
    {
        [JsiiProperty(name: "httpHeaderName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HttpHeaderName
        {
            get;
            set;
        }

        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Values
        {
            get;
            set;
        }
    }
}
