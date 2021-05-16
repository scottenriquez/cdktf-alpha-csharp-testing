using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafSizeConstraintSet), fullyQualifiedName: "aws.WafSizeConstraintSet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafSizeConstraintSetConfig\"}}]")]
    public class WafSizeConstraintSet : HashiCorp.Cdktf.TerraformResource
    {
        public WafSizeConstraintSet(Constructs.Construct scope, string id, aws.IWafSizeConstraintSetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafSizeConstraintSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafSizeConstraintSet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSizeConstraints")]
        public virtual void ResetSizeConstraints()
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
        [JsiiProperty(name: "sizeConstraintsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafSizeConstraintSetSizeConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafSizeConstraintSetSizeConstraints[]? SizeConstraintsInput
        {
            get => GetInstanceProperty<aws.IWafSizeConstraintSetSizeConstraints[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizeConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafSizeConstraintSetSizeConstraints\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafSizeConstraintSetSizeConstraints[] SizeConstraints
        {
            get => GetInstanceProperty<aws.IWafSizeConstraintSetSizeConstraints[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
