using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueCrawlerS3Target")]
    public class GlueCrawlerS3Target : aws.IGlueCrawlerS3Target
    {
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Path
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Exclusions
        {
            get;
            set;
        }
    }
}
