using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshRouteSpecHttpRouteMatchHeaderMatch")]
    public class AppmeshRouteSpecHttpRouteMatchHeaderMatch : aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatch
    {
        [JsiiOptional]
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Exact
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>range block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "range", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange[]? Range
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Regex
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Suffix
        {
            get;
            set;
        }
    }
}
