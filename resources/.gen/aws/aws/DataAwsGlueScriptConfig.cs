using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DataAwsGlueScriptConfig")]
    public class DataAwsGlueScriptConfig : aws.IDataAwsGlueScriptConfig
    {
        /// <summary>dag_edge block.</summary>
        [JsiiProperty(name: "dagEdge", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IDataAwsGlueScriptDagEdge[] DagEdge
        {
            get;
            set;
        }

        /// <summary>dag_node block.</summary>
        [JsiiProperty(name: "dagNode", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IDataAwsGlueScriptDagNode[] DagNode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Language
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
