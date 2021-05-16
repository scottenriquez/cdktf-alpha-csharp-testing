using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodepipelineConfig), fullyQualifiedName: "aws.CodepipelineConfig")]
    public interface ICodepipelineConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>artifact_store block.</summary>
        [JsiiProperty(name: "artifactStore", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineArtifactStore\"},\"kind\":\"array\"}}")]
        aws.ICodepipelineArtifactStore[] ArtifactStore
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>stage block.</summary>
        [JsiiProperty(name: "stage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineStage\"},\"kind\":\"array\"}}")]
        aws.ICodepipelineStage[] Stage
        {
            get;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineConfig), fullyQualifiedName: "aws.CodepipelineConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodepipelineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>artifact_store block.</summary>
            [JsiiProperty(name: "artifactStore", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineArtifactStore\"},\"kind\":\"array\"}}")]
            public aws.ICodepipelineArtifactStore[] ArtifactStore
            {
                get => GetInstanceProperty<aws.ICodepipelineArtifactStore[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>stage block.</summary>
            [JsiiProperty(name: "stage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineStage\"},\"kind\":\"array\"}}")]
            public aws.ICodepipelineStage[] Stage
            {
                get => GetInstanceProperty<aws.ICodepipelineStage[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
