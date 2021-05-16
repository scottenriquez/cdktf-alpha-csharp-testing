using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DxTransitVirtualInterface), fullyQualifiedName: "aws.DxTransitVirtualInterface", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DxTransitVirtualInterfaceConfig\"}}]")]
    public class DxTransitVirtualInterface : HashiCorp.Cdktf.TerraformResource
    {
        public DxTransitVirtualInterface(Constructs.Construct scope, string id, aws.IDxTransitVirtualInterfaceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxTransitVirtualInterface(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxTransitVirtualInterface(DeputyProps props): base(props)
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

        [JsiiMethod(name: "resetMtu")]
        public virtual void ResetMtu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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

        [JsiiProperty(name: "amazonSideAsn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AmazonSideAsn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
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

        [JsiiProperty(name: "connectionIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dxGatewayIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DxGatewayIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jumboFrameCapable", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool JumboFrameCapable
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vlanInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VlanInput
        {
            get => GetInstanceProperty<double>()!;
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
        [JsiiProperty(name: "mtuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MtuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.DxTransitVirtualInterfaceTimeouts\"}", isOptional: true)]
        public virtual aws.IDxTransitVirtualInterfaceTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IDxTransitVirtualInterfaceTimeouts?>();
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

        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionId
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

        [JsiiProperty(name: "dxGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DxGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mtu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Mtu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DxTransitVirtualInterfaceTimeouts\"}")]
        public virtual aws.IDxTransitVirtualInterfaceTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IDxTransitVirtualInterfaceTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vlan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
