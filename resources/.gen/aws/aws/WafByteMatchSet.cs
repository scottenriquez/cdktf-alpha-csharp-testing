using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafByteMatchSet), fullyQualifiedName: "aws.WafByteMatchSet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafByteMatchSetConfig\"}}]")]
    public class WafByteMatchSet : HashiCorp.Cdktf.TerraformResource
    {
        public WafByteMatchSet(Constructs.Construct scope, string id, aws.IWafByteMatchSetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafByteMatchSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafByteMatchSet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetByteMatchTuples")]
        public virtual void ResetByteMatchTuples()
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
        [JsiiProperty(name: "byteMatchTuplesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafByteMatchSetByteMatchTuples\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafByteMatchSetByteMatchTuples[]? ByteMatchTuplesInput
        {
            get => GetInstanceProperty<aws.IWafByteMatchSetByteMatchTuples[]?>();
        }

        [JsiiProperty(name: "byteMatchTuples", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafByteMatchSetByteMatchTuples\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafByteMatchSetByteMatchTuples[] ByteMatchTuples
        {
            get => GetInstanceProperty<aws.IWafByteMatchSetByteMatchTuples[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
