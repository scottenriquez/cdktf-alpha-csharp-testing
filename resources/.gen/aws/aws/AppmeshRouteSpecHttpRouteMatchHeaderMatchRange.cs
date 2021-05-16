using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange")]
    public class AppmeshRouteSpecHttpRouteMatchHeaderMatchRange : aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange
    {
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double End
        {
            get;
            set;
        }

        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Start
        {
            get;
            set;
        }
    }
}
