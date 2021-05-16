using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SecretsmanagerSecretRotation), fullyQualifiedName: "aws.SecretsmanagerSecretRotation", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SecretsmanagerSecretRotationConfig\"}}]")]
    public class SecretsmanagerSecretRotation : HashiCorp.Cdktf.TerraformResource
    {
        public SecretsmanagerSecretRotation(Constructs.Construct scope, string id, aws.ISecretsmanagerSecretRotationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecretsmanagerSecretRotation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecretsmanagerSecretRotation(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rotationEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RotationEnabled
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "rotationLambdaArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationLambdaArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rotationRulesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SecretsmanagerSecretRotationRotationRules\"},\"kind\":\"array\"}}")]
        public virtual aws.ISecretsmanagerSecretRotationRotationRules[] RotationRulesInput
        {
            get => GetInstanceProperty<aws.ISecretsmanagerSecretRotationRotationRules[]>()!;
        }

        [JsiiProperty(name: "secretIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "rotationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationLambdaArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rotationRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SecretsmanagerSecretRotationRotationRules\"},\"kind\":\"array\"}}")]
        public virtual aws.ISecretsmanagerSecretRotationRotationRules[] RotationRules
        {
            get => GetInstanceProperty<aws.ISecretsmanagerSecretRotationRotationRules[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
