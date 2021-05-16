using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteActionWeightedTarget), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteActionWeightedTarget")]
    public interface IAppmeshRouteSpecHttpRouteActionWeightedTarget
    {
        [JsiiProperty(name: "virtualNode", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualNode
        {
            get;
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteActionWeightedTarget), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteActionWeightedTarget")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecHttpRouteActionWeightedTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "virtualNode", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualNode
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
