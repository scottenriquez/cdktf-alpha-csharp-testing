using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IVpcPeeringConnectionOptionsConfig), fullyQualifiedName: "aws.VpcPeeringConnectionOptionsConfig")]
    public interface IVpcPeeringConnectionOptionsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcPeeringConnectionId
        {
            get;
        }

        /// <summary>accepter block.</summary>
        [JsiiProperty(name: "accepter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsAccepter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IVpcPeeringConnectionOptionsAccepter[]? Accepter
        {
            get
            {
                return null;
            }
        }

        /// <summary>requester block.</summary>
        [JsiiProperty(name: "requester", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsRequester\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IVpcPeeringConnectionOptionsRequester[]? Requester
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcPeeringConnectionOptionsConfig), fullyQualifiedName: "aws.VpcPeeringConnectionOptionsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IVpcPeeringConnectionOptionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcPeeringConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>accepter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accepter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsAccepter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IVpcPeeringConnectionOptionsAccepter[]? Accepter
            {
                get => GetInstanceProperty<aws.IVpcPeeringConnectionOptionsAccepter[]?>();
            }

            /// <summary>requester block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requester", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsRequester\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IVpcPeeringConnectionOptionsRequester[]? Requester
            {
                get => GetInstanceProperty<aws.IVpcPeeringConnectionOptionsRequester[]?>();
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
