using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecTcpRoute), fullyQualifiedName: "aws.AppmeshRouteSpecTcpRoute")]
    public interface IAppmeshRouteSpecTcpRoute
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecTcpRouteAction\"},\"kind\":\"array\"}}")]
        aws.IAppmeshRouteSpecTcpRouteAction[] Action
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecTcpRoute), fullyQualifiedName: "aws.AppmeshRouteSpecTcpRoute")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecTcpRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecTcpRouteAction\"},\"kind\":\"array\"}}")]
            public aws.IAppmeshRouteSpecTcpRouteAction[] Action
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecTcpRouteAction[]>()!;
            }
        }
    }
}
