using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ConfigConfigRuleScope")]
    public class ConfigConfigRuleScope : aws.IConfigConfigRuleScope
    {
        [JsiiOptional]
        [JsiiProperty(name: "complianceResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ComplianceResourceId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "complianceResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ComplianceResourceTypes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TagKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TagValue
        {
            get;
            set;
        }
    }
}
