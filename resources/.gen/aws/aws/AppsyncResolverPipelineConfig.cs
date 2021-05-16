using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppsyncResolverPipelineConfig")]
    public class AppsyncResolverPipelineConfig : aws.IAppsyncResolverPipelineConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "functions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Functions
        {
            get;
            set;
        }
    }
}
