using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.VpcPeeringConnectionAccepterA), fullyQualifiedName: "aws.VpcPeeringConnectionAccepterA", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.VpcPeeringConnectionAccepterAConfig\"}}]")]
    public class VpcPeeringConnectionAccepterA : HashiCorp.Cdktf.TerraformResource
    {
        public VpcPeeringConnectionAccepterA(Constructs.Construct scope, string id, aws.IVpcPeeringConnectionAccepterAConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionAccepterA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionAccepterA(DeputyProps props): base(props)
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

        [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerOwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerVpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcPeeringConnectionIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcPeeringConnectionIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accepterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionAccepterAccepter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IVpcPeeringConnectionAccepterAccepter[]? AccepterInput
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionAccepterAccepter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoAcceptInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AutoAcceptInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionAccepterRequester\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IVpcPeeringConnectionAccepterRequester[]? RequesterInput
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionAccepterRequester[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "accepter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionAccepterAccepter\"},\"kind\":\"array\"}}")]
        public virtual aws.IVpcPeeringConnectionAccepterAccepter[] Accepter
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionAccepterAccepter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoAccept", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AutoAccept
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requester", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionAccepterRequester\"},\"kind\":\"array\"}}")]
        public virtual aws.IVpcPeeringConnectionAccepterRequester[] Requester
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionAccepterRequester[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcPeeringConnectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
