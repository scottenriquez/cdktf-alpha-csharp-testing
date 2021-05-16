using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafRulePredicates")]
    public class WafRulePredicates : aws.IWafRulePredicates
    {
        [JsiiProperty(name: "dataId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DataId
        {
            get;
            set;
        }

        [JsiiProperty(name: "negated", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Negated
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }
    }
}
