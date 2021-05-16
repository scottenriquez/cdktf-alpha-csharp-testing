using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueTriggerPredicateConditions), fullyQualifiedName: "aws.GlueTriggerPredicateConditions")]
    public interface IGlueTriggerPredicateConditions
    {
        [JsiiProperty(name: "crawlerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrawlerName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "crawlState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrawlState
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "logicalOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogicalOperator
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueTriggerPredicateConditions), fullyQualifiedName: "aws.GlueTriggerPredicateConditions")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueTriggerPredicateConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "crawlerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrawlerName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "crawlState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrawlState
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "logicalOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogicalOperator
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
