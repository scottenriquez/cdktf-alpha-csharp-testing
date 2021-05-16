using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.VpcPeeringConnectionOptionsConfig")]
    public class VpcPeeringConnectionOptionsConfig : aws.IVpcPeeringConnectionOptionsConfig
    {
        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VpcPeeringConnectionId
        {
            get;
            set;
        }

        /// <summary>accepter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accepter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsAccepter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IVpcPeeringConnectionOptionsAccepter[]? Accepter
        {
            get;
            set;
        }

        /// <summary>requester block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requester", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsRequester\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IVpcPeeringConnectionOptionsRequester[]? Requester
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
