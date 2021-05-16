using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppsyncResolverCachingConfig")]
    public class AppsyncResolverCachingConfig : aws.IAppsyncResolverCachingConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "cachingKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? CachingKeys
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Ttl
        {
            get;
            set;
        }
    }
}
