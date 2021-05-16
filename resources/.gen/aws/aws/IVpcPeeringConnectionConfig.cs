using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IVpcPeeringConnectionConfig), fullyQualifiedName: "aws.VpcPeeringConnectionConfig")]
    public interface IVpcPeeringConnectionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}")]
        string PeerVpcId
        {
            get;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcId
        {
            get;
        }

        /// <summary>accepter block.</summary>
        [JsiiProperty(name: "accepter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionAccepter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IVpcPeeringConnectionAccepter[]? Accepter
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "autoAccept", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AutoAccept
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerOwnerId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>requester block.</summary>
        [JsiiProperty(name: "requester", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionRequester\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IVpcPeeringConnectionRequester[]? Requester
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.VpcPeeringConnectionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IVpcPeeringConnectionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcPeeringConnectionConfig), fullyQualifiedName: "aws.VpcPeeringConnectionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IVpcPeeringConnectionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string PeerVpcId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>accepter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accepter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionAccepter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IVpcPeeringConnectionAccepter[]? Accepter
            {
                get => GetInstanceProperty<aws.IVpcPeeringConnectionAccepter[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoAccept", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AutoAccept
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerOwnerId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>requester block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requester", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionRequester\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IVpcPeeringConnectionRequester[]? Requester
            {
                get => GetInstanceProperty<aws.IVpcPeeringConnectionRequester[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.VpcPeeringConnectionTimeouts\"}", isOptional: true)]
            public aws.IVpcPeeringConnectionTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IVpcPeeringConnectionTimeouts?>();
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
