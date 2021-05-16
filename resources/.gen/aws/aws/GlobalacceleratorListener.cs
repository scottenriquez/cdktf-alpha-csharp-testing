using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.GlobalacceleratorListener), fullyQualifiedName: "aws.GlobalacceleratorListener", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.GlobalacceleratorListenerConfig\"}}]")]
    public class GlobalacceleratorListener : HashiCorp.Cdktf.TerraformResource
    {
        public GlobalacceleratorListener(Constructs.Construct scope, string id, aws.IGlobalacceleratorListenerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorListener(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorListener(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClientAffinity")]
        public virtual void ResetClientAffinity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "acceleratorArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceleratorArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portRangeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlobalacceleratorListenerPortRange\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlobalacceleratorListenerPortRange[] PortRangeInput
        {
            get => GetInstanceProperty<aws.IGlobalacceleratorListenerPortRange[]>()!;
        }

        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtocolInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAffinityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientAffinityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acceleratorArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceleratorArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientAffinity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientAffinity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "portRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlobalacceleratorListenerPortRange\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlobalacceleratorListenerPortRange[] PortRange
        {
            get => GetInstanceProperty<aws.IGlobalacceleratorListenerPortRange[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
