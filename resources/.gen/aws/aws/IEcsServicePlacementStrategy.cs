using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsServicePlacementStrategy), fullyQualifiedName: "aws.EcsServicePlacementStrategy")]
    public interface IEcsServicePlacementStrategy
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Field
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServicePlacementStrategy), fullyQualifiedName: "aws.EcsServicePlacementStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsServicePlacementStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Field
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
