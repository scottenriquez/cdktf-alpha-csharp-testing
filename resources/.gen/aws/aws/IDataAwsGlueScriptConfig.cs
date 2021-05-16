using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsGlueScriptConfig), fullyQualifiedName: "aws.DataAwsGlueScriptConfig")]
    public interface IDataAwsGlueScriptConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>dag_edge block.</summary>
        [JsiiProperty(name: "dagEdge", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}")]
        aws.IDataAwsGlueScriptDagEdge[] DagEdge
        {
            get;
        }

        /// <summary>dag_node block.</summary>
        [JsiiProperty(name: "dagNode", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}")]
        aws.IDataAwsGlueScriptDagNode[] DagNode
        {
            get;
        }

        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Language
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsGlueScriptConfig), fullyQualifiedName: "aws.DataAwsGlueScriptConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsGlueScriptConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dag_edge block.</summary>
            [JsiiProperty(name: "dagEdge", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}")]
            public aws.IDataAwsGlueScriptDagEdge[] DagEdge
            {
                get => GetInstanceProperty<aws.IDataAwsGlueScriptDagEdge[]>()!;
            }

            /// <summary>dag_node block.</summary>
            [JsiiProperty(name: "dagNode", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}")]
            public aws.IDataAwsGlueScriptDagNode[] DagNode
            {
                get => GetInstanceProperty<aws.IDataAwsGlueScriptDagNode[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Language
            {
                get => GetInstanceProperty<string?>();
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
