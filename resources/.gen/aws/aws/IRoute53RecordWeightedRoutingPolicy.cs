using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordWeightedRoutingPolicy), fullyQualifiedName: "aws.Route53RecordWeightedRoutingPolicy")]
    public interface IRoute53RecordWeightedRoutingPolicy
    {
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordWeightedRoutingPolicy), fullyQualifiedName: "aws.Route53RecordWeightedRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.IRoute53RecordWeightedRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
