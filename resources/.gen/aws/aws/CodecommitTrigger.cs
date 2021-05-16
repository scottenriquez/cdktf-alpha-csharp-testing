using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CodecommitTrigger), fullyQualifiedName: "aws.CodecommitTrigger", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CodecommitTriggerConfig\"}}]")]
    public class CodecommitTrigger : HashiCorp.Cdktf.TerraformResource
    {
        public CodecommitTrigger(Constructs.Construct scope, string id, aws.ICodecommitTriggerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodecommitTrigger(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodecommitTrigger(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repositoryNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "triggerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodecommitTriggerTrigger\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodecommitTriggerTrigger[] TriggerInput
        {
            get => GetInstanceProperty<aws.ICodecommitTriggerTrigger[]>()!;
        }

        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trigger", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodecommitTriggerTrigger\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodecommitTriggerTrigger[] Trigger
        {
            get => GetInstanceProperty<aws.ICodecommitTriggerTrigger[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
