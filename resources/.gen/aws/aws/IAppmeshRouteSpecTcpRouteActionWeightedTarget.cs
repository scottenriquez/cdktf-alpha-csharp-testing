using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecTcpRouteActionWeightedTarget), fullyQualifiedName: "aws.AppmeshRouteSpecTcpRouteActionWeightedTarget")]
    public interface IAppmeshRouteSpecTcpRouteActionWeightedTarget
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

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecTcpRouteActionWeightedTarget), fullyQualifiedName: "aws.AppmeshRouteSpecTcpRouteActionWeightedTarget")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecTcpRouteActionWeightedTarget
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
