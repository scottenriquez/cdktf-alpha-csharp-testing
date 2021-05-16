using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshRouteSpec")]
    public class AppmeshRouteSpec : aws.IAppmeshRouteSpec
    {
        /// <summary>http_route block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRoute\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshRouteSpecHttpRoute[]? HttpRoute
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>tcp_route block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tcpRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecTcpRoute\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshRouteSpecTcpRoute[]? TcpRoute
        {
            get;
            set;
        }
    }
}
