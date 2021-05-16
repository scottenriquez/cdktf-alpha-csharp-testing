using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpec), fullyQualifiedName: "aws.AppmeshRouteSpec")]
    public interface IAppmeshRouteSpec
    {
        /// <summary>http_route block.</summary>
        [JsiiProperty(name: "httpRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRoute\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshRouteSpecHttpRoute[]? HttpRoute
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp_route block.</summary>
        [JsiiProperty(name: "tcpRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecTcpRoute\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshRouteSpecTcpRoute[]? TcpRoute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpec), fullyQualifiedName: "aws.AppmeshRouteSpec")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>http_route block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRoute\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshRouteSpecHttpRoute[]? HttpRoute
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecHttpRoute[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>tcp_route block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tcpRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecTcpRoute\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshRouteSpecTcpRoute[]? TcpRoute
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecTcpRoute[]?>();
            }
        }
    }
}
