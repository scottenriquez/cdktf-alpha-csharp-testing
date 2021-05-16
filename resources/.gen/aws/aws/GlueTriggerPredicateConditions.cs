using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueTriggerPredicateConditions")]
    public class GlueTriggerPredicateConditions : aws.IGlueTriggerPredicateConditions
    {
        [JsiiOptional]
        [JsiiProperty(name: "crawlerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CrawlerName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "crawlState", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CrawlState
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
        [JsiiProperty(name: "logicalOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LogicalOperator
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? State
        {
            get;
            set;
        }
    }
}
