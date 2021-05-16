using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshRouteSpecHttpRouteMatchHeader")]
    public class AppmeshRouteSpecHttpRouteMatchHeader : aws.IAppmeshRouteSpecHttpRouteMatchHeader
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "invert", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Invert
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatchHeaderMatch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatch[]? Match
        {
            get;
            set;
        }
    }
}
