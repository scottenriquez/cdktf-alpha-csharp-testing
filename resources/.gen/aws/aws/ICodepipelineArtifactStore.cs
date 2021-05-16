using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodepipelineArtifactStore), fullyQualifiedName: "aws.CodepipelineArtifactStore")]
    public interface ICodepipelineArtifactStore
    {
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>encryption_key block.</summary>
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineArtifactStoreEncryptionKey\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodepipelineArtifactStoreEncryptionKey[]? EncryptionKey
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineArtifactStore), fullyQualifiedName: "aws.CodepipelineArtifactStore")]
        internal sealed class _Proxy : DeputyBase, aws.ICodepipelineArtifactStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>encryption_key block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKey", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineArtifactStoreEncryptionKey\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodepipelineArtifactStoreEncryptionKey[]? EncryptionKey
            {
                get => GetInstanceProperty<aws.ICodepipelineArtifactStoreEncryptionKey[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
