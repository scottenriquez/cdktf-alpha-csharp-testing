using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafregionalIpset), fullyQualifiedName: "aws.WafregionalIpset", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafregionalIpsetConfig\"}}]")]
    public class WafregionalIpset : HashiCorp.Cdktf.TerraformResource
    {
        public WafregionalIpset(Constructs.Construct scope, string id, aws.IWafregionalIpsetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalIpset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalIpset(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIpSetDescriptor")]
        public virtual void ResetIpSetDescriptor()
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
        [JsiiProperty(name: "ipSetDescriptorInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalIpsetIpSetDescriptor\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafregionalIpsetIpSetDescriptor[]? IpSetDescriptorInput
        {
            get => GetInstanceProperty<aws.IWafregionalIpsetIpSetDescriptor[]?>();
        }

        [JsiiProperty(name: "ipSetDescriptor", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalIpsetIpSetDescriptor\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafregionalIpsetIpSetDescriptor[] IpSetDescriptor
        {
            get => GetInstanceProperty<aws.IWafregionalIpsetIpSetDescriptor[]>()!;
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
