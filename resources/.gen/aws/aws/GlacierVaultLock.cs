using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.GlacierVaultLock), fullyQualifiedName: "aws.GlacierVaultLock", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.GlacierVaultLockConfig\"}}]")]
    public class GlacierVaultLock : HashiCorp.Cdktf.TerraformResource
    {
        public GlacierVaultLock(Constructs.Construct scope, string id, aws.IGlacierVaultLockConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlacierVaultLock(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlacierVaultLock(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIgnoreDeletionError")]
        public virtual void ResetIgnoreDeletionError()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "completeLockInput", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool CompleteLockInput
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vaultNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignoreDeletionErrorInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? IgnoreDeletionErrorInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "completeLock", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool CompleteLock
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ignoreDeletionError", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool IgnoreDeletionError
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vaultName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
