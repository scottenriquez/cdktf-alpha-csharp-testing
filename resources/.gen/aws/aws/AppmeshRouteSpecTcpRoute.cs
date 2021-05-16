using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshRouteSpecTcpRoute")]
    public class AppmeshRouteSpecTcpRoute : aws.IAppmeshRouteSpecTcpRoute
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecTcpRouteAction\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAppmeshRouteSpecTcpRouteAction[] Action
        {
            get;
            set;
        }
    }
}
