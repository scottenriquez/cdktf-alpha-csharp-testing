using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.VpcPeeringConnection), fullyQualifiedName: "aws.VpcPeeringConnection", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.VpcPeeringConnectionConfig\"}}]")]
    public class VpcPeeringConnection : HashiCorp.Cdktf.TerraformResource
    {
        public VpcPeeringConnection(Constructs.Construct scope, string id, aws.IVpcPeeringConnectionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnection(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccepter")]
        public virtual void ResetAccepter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoAccept")]
        public virtual void ResetAutoAccept()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerOwnerId")]
        public virtual void ResetPeerOwnerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerRegion")]
        public virtual void ResetPeerRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequester")]
        public virtual void ResetRequester()
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

        [JsiiProperty(name: "acceptStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceptStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerVpcIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerVpcIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accepterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionAccepter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IVpcPeeringConnectionAccepter[]? AccepterInput
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionAccepter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoAcceptInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AutoAcceptInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerOwnerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeerOwnerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeerRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionRequester\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IVpcPeeringConnectionRequester[]? RequesterInput
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionRequester[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.VpcPeeringConnectionTimeouts\"}", isOptional: true)]
        public virtual aws.IVpcPeeringConnectionTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionTimeouts?>();
        }

        [JsiiProperty(name: "accepter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionAccepter\"},\"kind\":\"array\"}}")]
        public virtual aws.IVpcPeeringConnectionAccepter[] Accepter
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionAccepter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoAccept", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AutoAccept
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerOwnerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerVpcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requester", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionRequester\"},\"kind\":\"array\"}}")]
        public virtual aws.IVpcPeeringConnectionRequester[] Requester
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionRequester[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.VpcPeeringConnectionTimeouts\"}")]
        public virtual aws.IVpcPeeringConnectionTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
