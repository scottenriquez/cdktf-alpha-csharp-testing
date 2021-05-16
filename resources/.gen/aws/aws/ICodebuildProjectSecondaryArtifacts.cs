using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSecondaryArtifacts), fullyQualifiedName: "aws.CodebuildProjectSecondaryArtifacts")]
    public interface ICodebuildProjectSecondaryArtifacts
    {
        [JsiiProperty(name: "artifactIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ArtifactIdentifier
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "encryptionDisabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EncryptionDisabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "namespaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamespaceType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "overrideArtifactName", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? OverrideArtifactName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "packaging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Packaging
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSecondaryArtifacts), fullyQualifiedName: "aws.CodebuildProjectSecondaryArtifacts")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildProjectSecondaryArtifacts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "artifactIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ArtifactIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "encryptionDisabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EncryptionDisabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "namespaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamespaceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "overrideArtifactName", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? OverrideArtifactName
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "packaging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Packaging
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
