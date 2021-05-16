using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshMeshSpecEgressFilter), fullyQualifiedName: "aws.AppmeshMeshSpecEgressFilter")]
    public interface IAppmeshMeshSpecEgressFilter
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshMeshSpecEgressFilter), fullyQualifiedName: "aws.AppmeshMeshSpecEgressFilter")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshMeshSpecEgressFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
