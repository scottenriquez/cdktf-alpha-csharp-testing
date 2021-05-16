using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AlbListenerRuleConditionQueryString")]
    public class AlbListenerRuleConditionQueryString : aws.IAlbListenerRuleConditionQueryString
    {
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Value
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Key
        {
            get;
            set;
        }
    }
}
