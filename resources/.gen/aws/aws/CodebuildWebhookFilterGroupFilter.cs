using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodebuildWebhookFilterGroupFilter")]
    public class CodebuildWebhookFilterGroupFilter : aws.ICodebuildWebhookFilterGroupFilter
    {
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Pattern
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

        [JsiiOptional]
        [JsiiProperty(name: "excludeMatchedPattern", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ExcludeMatchedPattern
        {
            get;
            set;
        }
    }
}
