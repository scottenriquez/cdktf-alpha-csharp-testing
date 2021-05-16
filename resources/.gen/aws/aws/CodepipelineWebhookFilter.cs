using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodepipelineWebhookFilter")]
    public class CodepipelineWebhookFilter : aws.ICodepipelineWebhookFilter
    {
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string JsonPath
        {
            get;
            set;
        }

        [JsiiProperty(name: "matchEquals", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MatchEquals
        {
            get;
            set;
        }
    }
}
