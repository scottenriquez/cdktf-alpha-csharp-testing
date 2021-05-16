using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordLatencyRoutingPolicy), fullyQualifiedName: "aws.Route53RecordLatencyRoutingPolicy")]
    public interface IRoute53RecordLatencyRoutingPolicy
    {
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordLatencyRoutingPolicy), fullyQualifiedName: "aws.Route53RecordLatencyRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.IRoute53RecordLatencyRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
