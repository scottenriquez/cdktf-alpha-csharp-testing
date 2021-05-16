using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafRegexMatchSet), fullyQualifiedName: "aws.WafRegexMatchSet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafRegexMatchSetConfig\"}}]")]
    public class WafRegexMatchSet : HashiCorp.Cdktf.TerraformResource
    {
        public WafRegexMatchSet(Constructs.Construct scope, string id, aws.IWafRegexMatchSetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafRegexMatchSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafRegexMatchSet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRegexMatchTuple")]
        public virtual void ResetRegexMatchTuple()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "regexMatchTupleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafRegexMatchSetRegexMatchTuple\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafRegexMatchSetRegexMatchTuple[]? RegexMatchTupleInput
        {
            get => GetInstanceProperty<aws.IWafRegexMatchSetRegexMatchTuple[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regexMatchTuple", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafRegexMatchSetRegexMatchTuple\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafRegexMatchSetRegexMatchTuple[] RegexMatchTuple
        {
            get => GetInstanceProperty<aws.IWafRegexMatchSetRegexMatchTuple[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
