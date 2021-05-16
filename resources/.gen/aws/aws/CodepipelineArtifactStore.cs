using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodepipelineArtifactStore")]
    public class CodepipelineArtifactStore : aws.ICodepipelineArtifactStore
    {
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Location
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

        /// <summary>encryption_key block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineArtifactStoreEncryptionKey\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodepipelineArtifactStoreEncryptionKey[]? EncryptionKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Region
        {
            get;
            set;
        }
    }
}
