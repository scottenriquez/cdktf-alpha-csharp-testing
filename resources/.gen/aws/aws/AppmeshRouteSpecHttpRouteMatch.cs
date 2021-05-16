using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshRouteSpecHttpRouteMatch")]
    public class AppmeshRouteSpecHttpRouteMatch : aws.IAppmeshRouteSpecHttpRouteMatch
    {
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Prefix
        {
            get;
            set;
        }

        /// <summary>header block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatchHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshRouteSpecHttpRouteMatchHeader[]? Header
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Method
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Scheme
        {
            get;
            set;
        }
    }
}
