using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodepipelineArtifactStoreEncryptionKey), fullyQualifiedName: "aws.CodepipelineArtifactStoreEncryptionKey")]
    public interface ICodepipelineArtifactStoreEncryptionKey
    {
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineArtifactStoreEncryptionKey), fullyQualifiedName: "aws.CodepipelineArtifactStoreEncryptionKey")]
        internal sealed class _Proxy : DeputyBase, aws.ICodepipelineArtifactStoreEncryptionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
