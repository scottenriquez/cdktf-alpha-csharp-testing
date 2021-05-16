using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafSqlInjectionMatchSet), fullyQualifiedName: "aws.WafSqlInjectionMatchSet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafSqlInjectionMatchSetConfig\"}}]")]
    public class WafSqlInjectionMatchSet : HashiCorp.Cdktf.TerraformResource
    {
        public WafSqlInjectionMatchSet(Constructs.Construct scope, string id, aws.IWafSqlInjectionMatchSetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafSqlInjectionMatchSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafSqlInjectionMatchSet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSqlInjectionMatchTuples")]
        public virtual void ResetSqlInjectionMatchTuples()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlInjectionMatchTuplesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafSqlInjectionMatchSetSqlInjectionMatchTuples\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuples[]? SqlInjectionMatchTuplesInput
        {
            get => GetInstanceProperty<aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuples[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlInjectionMatchTuples", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafSqlInjectionMatchSetSqlInjectionMatchTuples\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuples[] SqlInjectionMatchTuples
        {
            get => GetInstanceProperty<aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuples[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
