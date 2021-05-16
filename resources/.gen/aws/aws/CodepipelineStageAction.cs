using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodepipelineStageAction")]
    public class CodepipelineStageAction : aws.ICodepipelineStageAction
    {
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Category
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Owner
        {
            get;
            set;
        }

        [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Provider
        {
            get;
            set;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Version
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Configuration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? InputArtifacts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Namespace
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? OutputArtifacts
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

        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "runOrder", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RunOrder
        {
            get;
            set;
        }
    }
}
