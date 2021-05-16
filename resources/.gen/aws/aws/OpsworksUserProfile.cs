using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.OpsworksUserProfile), fullyQualifiedName: "aws.OpsworksUserProfile", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.OpsworksUserProfileConfig\"}}]")]
    public class OpsworksUserProfile : HashiCorp.Cdktf.TerraformResource
    {
        public OpsworksUserProfile(Constructs.Construct scope, string id, aws.IOpsworksUserProfileConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksUserProfile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksUserProfile(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllowSelfManagement")]
        public virtual void ResetAllowSelfManagement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshPublicKey")]
        public virtual void ResetSshPublicKey()
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

        [JsiiProperty(name: "sshUsernameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshUsernameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowSelfManagementInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AllowSelfManagementInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshPublicKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SshPublicKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowSelfManagement", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AllowSelfManagement
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshPublicKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
