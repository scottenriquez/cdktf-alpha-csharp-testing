using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDxHostedPublicVirtualInterfaceConfig), fullyQualifiedName: "aws.DxHostedPublicVirtualInterfaceConfig")]
    public interface IDxHostedPublicVirtualInterfaceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
        string AddressFamily
        {
            get;
        }

        [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        double BgpAsn
        {
            get;
        }

        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionId
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "ownerAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string OwnerAccountId
        {
            get;
        }

        [JsiiProperty(name: "routeFilterPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] RouteFilterPrefixes
        {
            get;
        }

        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
        double Vlan
        {
            get;
        }

        [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmazonAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BgpAuthKey
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DxHostedPublicVirtualInterfaceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDxHostedPublicVirtualInterfaceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDxHostedPublicVirtualInterfaceConfig), fullyQualifiedName: "aws.DxHostedPublicVirtualInterfaceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDxHostedPublicVirtualInterfaceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressFamily
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}")]
            public double BgpAsn
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "ownerAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string OwnerAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "routeFilterPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] RouteFilterPrefixes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
            public double Vlan
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmazonAddress
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BgpAuthKey
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DxHostedPublicVirtualInterfaceTimeouts\"}", isOptional: true)]
            public aws.IDxHostedPublicVirtualInterfaceTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IDxHostedPublicVirtualInterfaceTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
