using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.VpcPeeringConnectionOptions), fullyQualifiedName: "aws.VpcPeeringConnectionOptions", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsConfig\"}}]")]
    public class VpcPeeringConnectionOptions : HashiCorp.Cdktf.TerraformResource
    {
        public VpcPeeringConnectionOptions(Constructs.Construct scope, string id, aws.IVpcPeeringConnectionOptionsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionOptions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionOptions(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccepter")]
        public virtual void ResetAccepter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequester")]
        public virtual void ResetRequester()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcPeeringConnectionIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcPeeringConnectionIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accepterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsAccepter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IVpcPeeringConnectionOptionsAccepter[]? AccepterInput
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionOptionsAccepter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsRequester\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IVpcPeeringConnectionOptionsRequester[]? RequesterInput
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionOptionsRequester[]?>();
        }

        [JsiiProperty(name: "accepter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsAccepter\"},\"kind\":\"array\"}}")]
        public virtual aws.IVpcPeeringConnectionOptionsAccepter[] Accepter
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionOptionsAccepter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requester", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.VpcPeeringConnectionOptionsRequester\"},\"kind\":\"array\"}}")]
        public virtual aws.IVpcPeeringConnectionOptionsRequester[] Requester
        {
            get => GetInstanceProperty<aws.IVpcPeeringConnectionOptionsRequester[]>()!;
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
