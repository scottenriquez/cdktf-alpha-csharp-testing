using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AlbListener), fullyQualifiedName: "aws.AlbListener", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AlbListenerConfig\"}}]")]
    public class AlbListener : HashiCorp.Cdktf.TerraformResource
    {
        public AlbListener(Constructs.Construct scope, string id, aws.IAlbListenerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListener(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListener(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCertificateArn")]
        public virtual void ResetCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslPolicy")]
        public virtual void ResetSslPolicy()
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

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IAlbListenerDefaultAction[] DefaultActionInput
        {
            get => GetInstanceProperty<aws.IAlbListenerDefaultAction[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PortInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.AlbListenerTimeouts\"}", isOptional: true)]
        public virtual aws.IAlbListenerTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IAlbListenerTimeouts?>();
        }

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IAlbListenerDefaultAction[] DefaultAction
        {
            get => GetInstanceProperty<aws.IAlbListenerDefaultAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancerArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AlbListenerTimeouts\"}")]
        public virtual aws.IAlbListenerTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IAlbListenerTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}
