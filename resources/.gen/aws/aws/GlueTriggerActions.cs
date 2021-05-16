using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueTriggerActions")]
    public class GlueTriggerActions : aws.IGlueTriggerActions
    {
        [JsiiOptional]
        [JsiiProperty(name: "arguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Arguments
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "crawlerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CrawlerName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? JobName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Timeout
        {
            get;
            set;
        }
    }
}
