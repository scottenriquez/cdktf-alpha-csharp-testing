using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordFailoverRoutingPolicy), fullyQualifiedName: "aws.Route53RecordFailoverRoutingPolicy")]
    public interface IRoute53RecordFailoverRoutingPolicy
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordFailoverRoutingPolicy), fullyQualifiedName: "aws.Route53RecordFailoverRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.IRoute53RecordFailoverRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
