using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.KmsGrant), fullyQualifiedName: "aws.KmsGrant", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.KmsGrantConfig\"}}]")]
    public class KmsGrant : HashiCorp.Cdktf.TerraformResource
    {
        public KmsGrant(Constructs.Construct scope, string id, aws.IKmsGrantConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsGrant(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsGrant(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConstraints")]
        public virtual void ResetConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrantCreationTokens")]
        public virtual void ResetGrantCreationTokens()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetireOnDelete")]
        public virtual void ResetRetireOnDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetiringPrincipal")]
        public virtual void ResetRetiringPrincipal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "granteePrincipalInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GranteePrincipalInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrantToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OperationsInput
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "constraintsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KmsGrantConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKmsGrantConstraints[]? ConstraintsInput
        {
            get => GetInstanceProperty<aws.IKmsGrantConstraints[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantCreationTokensInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? GrantCreationTokensInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retireOnDeleteInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RetireOnDeleteInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retiringPrincipalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RetiringPrincipalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "constraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KmsGrantConstraints\"},\"kind\":\"array\"}}")]
        public virtual aws.IKmsGrantConstraints[] Constraints
        {
            get => GetInstanceProperty<aws.IKmsGrantConstraints[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "grantCreationTokens", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GrantCreationTokens
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "granteePrincipal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GranteePrincipal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Operations
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retireOnDelete", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RetireOnDelete
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retiringPrincipal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetiringPrincipal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
