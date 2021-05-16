using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.RamResourceShareAccepter), fullyQualifiedName: "aws.RamResourceShareAccepter", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.RamResourceShareAccepterConfig\"}}]")]
    public class RamResourceShareAccepter : HashiCorp.Cdktf.TerraformResource
    {
        public RamResourceShareAccepter(Constructs.Construct scope, string id, aws.IRamResourceShareAccepterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RamResourceShareAccepter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RamResourceShareAccepter(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invitationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvitationArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "receiverAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReceiverAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Resources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "senderAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SenderAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shareArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shareId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shareName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.RamResourceShareAccepterTimeouts\"}", isOptional: true)]
        public virtual aws.IRamResourceShareAccepterTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IRamResourceShareAccepterTimeouts?>();
        }

        [JsiiProperty(name: "shareArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.RamResourceShareAccepterTimeouts\"}")]
        public virtual aws.IRamResourceShareAccepterTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IRamResourceShareAccepterTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}
