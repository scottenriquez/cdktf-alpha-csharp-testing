using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationSmbMountOptions), fullyQualifiedName: "aws.DatasyncLocationSmbMountOptions")]
    public interface IDatasyncLocationSmbMountOptions
    {
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationSmbMountOptions), fullyQualifiedName: "aws.DatasyncLocationSmbMountOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IDatasyncLocationSmbMountOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
