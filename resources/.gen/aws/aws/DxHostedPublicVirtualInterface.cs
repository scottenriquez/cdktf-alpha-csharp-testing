using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DxHostedPublicVirtualInterface), fullyQualifiedName: "aws.DxHostedPublicVirtualInterface", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DxHostedPublicVirtualInterfaceConfig\"}}]")]
    public class DxHostedPublicVirtualInterface : HashiCorp.Cdktf.TerraformResource
    {
        public DxHostedPublicVirtualInterface(Constructs.Construct scope, string id, aws.IDxHostedPublicVirtualInterfaceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxHostedPublicVirtualInterface(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxHostedPublicVirtualInterface(DeputyProps props): base(props)
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

        [JsiiProperty(name: "ownerAccountIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerAccountIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeFilterPrefixesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RouteFilterPrefixesInput
        {
            get => GetInstanceProperty<string[]>()!;
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.DxHostedPublicVirtualInterfaceTimeouts\"}", isOptional: true)]
        public virtual aws.IDxHostedPublicVirtualInterfaceTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IDxHostedPublicVirtualInterfaceTimeouts?>();
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ownerAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routeFilterPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RouteFilterPrefixes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DxHostedPublicVirtualInterfaceTimeouts\"}")]
        public virtual aws.IDxHostedPublicVirtualInterfaceTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IDxHostedPublicVirtualInterfaceTimeouts>()!;
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
