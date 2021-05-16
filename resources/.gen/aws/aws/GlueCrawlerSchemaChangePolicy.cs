using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueCrawlerSchemaChangePolicy")]
    public class GlueCrawlerSchemaChangePolicy : aws.IGlueCrawlerSchemaChangePolicy
    {
        [JsiiOptional]
        [JsiiProperty(name: "deleteBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeleteBehavior
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UpdateBehavior
        {
            get;
            set;
        }
    }
}
