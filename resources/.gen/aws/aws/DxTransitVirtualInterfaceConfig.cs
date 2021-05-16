using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DxTransitVirtualInterfaceConfig")]
    public class DxTransitVirtualInterfaceConfig : aws.IDxTransitVirtualInterfaceConfig
    {
        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AddressFamily
        {
            get;
            set;
        }

        [JsiiProperty(name: "bgpAsn", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double BgpAsn
        {
            get;
            set;
        }

        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ConnectionId
        {
            get;
            set;
        }

        [JsiiProperty(name: "dxGatewayId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DxGatewayId
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Vlan
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amazonAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AmazonAddress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgpAuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BgpAuthKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomerAddress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mtu", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Mtu
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DxTransitVirtualInterfaceTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IDxTransitVirtualInterfaceTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
