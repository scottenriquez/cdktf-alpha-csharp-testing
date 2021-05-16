using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DxBgpPeer), fullyQualifiedName: "aws.DxBgpPeer", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DxBgpPeerConfig\"}}]")]
    public class DxBgpPeer : HashiCorp.Cdktf.TerraformResource
    {
        public DxBgpPeer(Constructs.Construct scope, string id, aws.IDxBgpPeerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxBgpPeer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxBgpPeer(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAmazonAddress")]
        public virtual void ResetAmazonAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBgpAuthKey")]
        public virtual void ResetBgpAuthKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerAddress")]
        public virtual void ResetCustomerAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "addressFamilyInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressFamilyInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awsDevice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsDevice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpAsnInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BgpAsnInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "bgpPeerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpPeerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualInterfaceIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualInterfaceIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amazonAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AmazonAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgpAuthKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BgpAuthKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.DxBgpPeerTimeouts\"}", isOptional: true)]
        public virtual aws.IDxBgpPeerTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IDxBgpPeerTimeouts?>();
        }

        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressFamily
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AmazonAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BgpAsn
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpAuthKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DxBgpPeerTimeouts\"}")]
        public virtual aws.IDxBgpPeerTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IDxBgpPeerTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualInterfaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
