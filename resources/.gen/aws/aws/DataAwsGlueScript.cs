using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsGlueScript), fullyQualifiedName: "aws.DataAwsGlueScript", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsGlueScriptConfig\"}}]")]
    public class DataAwsGlueScript : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsGlueScript(Constructs.Construct scope, string id, aws.IDataAwsGlueScriptConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueScript(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueScript(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLanguage")]
        public virtual void ResetLanguage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "dagEdgeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsGlueScriptDagEdge[] DagEdgeInput
        {
            get => GetInstanceProperty<aws.IDataAwsGlueScriptDagEdge[]>()!;
        }

        [JsiiProperty(name: "dagNodeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsGlueScriptDagNode[] DagNodeInput
        {
            get => GetInstanceProperty<aws.IDataAwsGlueScriptDagNode[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pythonScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PythonScript
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scalaCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScalaCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "languageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LanguageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dagEdge", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsGlueScriptDagEdge[] DagEdge
        {
            get => GetInstanceProperty<aws.IDataAwsGlueScriptDagEdge[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dagNode", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsGlueScriptDagNode[] DagNode
        {
            get => GetInstanceProperty<aws.IDataAwsGlueScriptDagNode[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Language
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
