using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshRouteSpecHttpRoute")]
    public class AppmeshRouteSpecHttpRoute : aws.IAppmeshRouteSpecHttpRoute
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteAction\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAppmeshRouteSpecHttpRouteAction[] Action
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        [JsiiProperty(name: "match", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatch\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAppmeshRouteSpecHttpRouteMatch[] Match
        {
            get;
            set;
        }
    }
}
