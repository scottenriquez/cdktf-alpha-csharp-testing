using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecTcpRouteAction), fullyQualifiedName: "aws.AppmeshRouteSpecTcpRouteAction")]
    public interface IAppmeshRouteSpecTcpRouteAction
    {
        /// <summary>weighted_target block.</summary>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecTcpRouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
        aws.IAppmeshRouteSpecTcpRouteActionWeightedTarget[] WeightedTarget
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecTcpRouteAction), fullyQualifiedName: "aws.AppmeshRouteSpecTcpRouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecTcpRouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>weighted_target block.</summary>
            [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecTcpRouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
            public aws.IAppmeshRouteSpecTcpRouteActionWeightedTarget[] WeightedTarget
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecTcpRouteActionWeightedTarget[]>()!;
            }
        }
    }
}
