using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ConfigConfigRuleSourceSourceDetail")]
    public class ConfigConfigRuleSourceSourceDetail : aws.IConfigConfigRuleSourceSourceDetail
    {
        [JsiiOptional]
        [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EventSource
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaximumExecutionFrequency
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MessageType
        {
            get;
            set;
        }
    }
}
