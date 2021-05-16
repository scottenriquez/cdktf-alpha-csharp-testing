using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteAction), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteAction")]
    public interface IAppmeshRouteSpecHttpRouteAction
    {
        /// <summary>weighted_target block.</summary>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
        aws.IAppmeshRouteSpecHttpRouteActionWeightedTarget[] WeightedTarget
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteAction), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecHttpRouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>weighted_target block.</summary>
            [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
            public aws.IAppmeshRouteSpecHttpRouteActionWeightedTarget[] WeightedTarget
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecHttpRouteActionWeightedTarget[]>()!;
            }
        }
    }
}
