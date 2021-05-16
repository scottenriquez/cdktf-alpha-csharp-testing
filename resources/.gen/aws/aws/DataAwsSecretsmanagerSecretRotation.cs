using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsSecretsmanagerSecretRotation), fullyQualifiedName: "aws.DataAwsSecretsmanagerSecretRotation", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsSecretsmanagerSecretRotationConfig\"}}]")]
    public class DataAwsSecretsmanagerSecretRotation : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsSecretsmanagerSecretRotation(Constructs.Construct scope, string id, aws.IDataAwsSecretsmanagerSecretRotationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecretsmanagerSecretRotation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecretsmanagerSecretRotation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "rotationRules", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsSecretsmanagerSecretRotationRotationRules\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsSecretsmanagerSecretRotationRotationRules RotationRules(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsSecretsmanagerSecretRotationRotationRules>(new System.Type[]{typeof(string)}, new object[]{index})!;
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

        [JsiiProperty(name: "rotationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationLambdaArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
