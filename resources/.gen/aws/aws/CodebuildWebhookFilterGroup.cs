using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodebuildWebhookFilterGroup")]
    public class CodebuildWebhookFilterGroup : aws.ICodebuildWebhookFilterGroup
    {
        /// <summary>filter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildWebhookFilterGroupFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildWebhookFilterGroupFilter[]? Filter
        {
            get;
            set;
        }
    }
}
