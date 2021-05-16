using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ResourcegroupsGroupResourceQuery")]
    public class ResourcegroupsGroupResourceQuery : aws.IResourcegroupsGroupResourceQuery
    {
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Query
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
