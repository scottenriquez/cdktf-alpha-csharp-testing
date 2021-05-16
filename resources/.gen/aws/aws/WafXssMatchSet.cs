using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafXssMatchSet), fullyQualifiedName: "aws.WafXssMatchSet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafXssMatchSetConfig\"}}]")]
    public class WafXssMatchSet : HashiCorp.Cdktf.TerraformResource
    {
        public WafXssMatchSet(Constructs.Construct scope, string id, aws.IWafXssMatchSetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafXssMatchSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafXssMatchSet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetXssMatchTuples")]
        public virtual void ResetXssMatchTuples()
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
        [JsiiProperty(name: "xssMatchTuplesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafXssMatchSetXssMatchTuples\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafXssMatchSetXssMatchTuples[]? XssMatchTuplesInput
        {
            get => GetInstanceProperty<aws.IWafXssMatchSetXssMatchTuples[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "xssMatchTuples", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafXssMatchSetXssMatchTuples\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafXssMatchSetXssMatchTuples[] XssMatchTuples
        {
            get => GetInstanceProperty<aws.IWafXssMatchSetXssMatchTuples[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
