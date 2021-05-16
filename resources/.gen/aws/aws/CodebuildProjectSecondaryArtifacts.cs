using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodebuildProjectSecondaryArtifacts")]
    public class CodebuildProjectSecondaryArtifacts : aws.ICodebuildProjectSecondaryArtifacts
    {
        [JsiiProperty(name: "artifactIdentifier", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ArtifactIdentifier
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionDisabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EncryptionDisabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Location
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NamespaceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideArtifactName", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? OverrideArtifactName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "packaging", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Packaging
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
