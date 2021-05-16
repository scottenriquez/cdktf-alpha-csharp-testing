using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.VpcPeeringConnectionConfig")]
    public class VpcPeeringConnectionConfig : aws.IVpcPeeringConnectionConfig
    {
        [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PeerVpcId
        {
            get;
            set;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VpcId
        {
            get;
            set;
        }

        /// <summary>accepter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accepter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionAccepter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IVpcPeeringConnectionAccepter[]? Accepter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoAccept", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AutoAccept
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PeerOwnerId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PeerRegion
        {
            get;
            set;
        }

        /// <summary>requester block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requester", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionRequester\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IVpcPeeringConnectionRequester[]? Requester
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.VpcPeeringConnectionTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IVpcPeeringConnectionTimeouts? Timeouts
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
