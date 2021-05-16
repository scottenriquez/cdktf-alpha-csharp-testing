using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDocdbClusterSnapshotTimeouts), fullyQualifiedName: "aws.DocdbClusterSnapshotTimeouts")]
    public interface IDocdbClusterSnapshotTimeouts
    {
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDocdbClusterSnapshotTimeouts), fullyQualifiedName: "aws.DocdbClusterSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.IDocdbClusterSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
