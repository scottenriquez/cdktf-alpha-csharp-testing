using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafregionalSqlInjectionMatchSet), fullyQualifiedName: "aws.WafregionalSqlInjectionMatchSet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafregionalSqlInjectionMatchSetConfig\"}}]")]
    public class WafregionalSqlInjectionMatchSet : HashiCorp.Cdktf.TerraformResource
    {
        public WafregionalSqlInjectionMatchSet(Constructs.Construct scope, string id, aws.IWafregionalSqlInjectionMatchSetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalSqlInjectionMatchSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalSqlInjectionMatchSet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSqlInjectionMatchTuple")]
        public virtual void ResetSqlInjectionMatchTuple()
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
        [JsiiProperty(name: "sqlInjectionMatchTupleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTuple\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple[]? SqlInjectionMatchTupleInput
        {
            get => GetInstanceProperty<aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlInjectionMatchTuple", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTuple\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple[] SqlInjectionMatchTuple
        {
            get => GetInstanceProperty<aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
