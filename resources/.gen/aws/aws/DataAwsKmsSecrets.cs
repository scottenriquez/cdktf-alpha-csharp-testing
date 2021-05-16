using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsKmsSecrets), fullyQualifiedName: "aws.DataAwsKmsSecrets", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsKmsSecretsConfig\"}}]")]
    public class DataAwsKmsSecrets : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsKmsSecrets(Constructs.Construct scope, string id, aws.IDataAwsKmsSecretsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsSecrets(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsSecrets(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "plaintext", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string Plaintext(string key)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string)}, new object[]{key})!;
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

        [JsiiProperty(name: "secretInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsKmsSecretsSecret\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsKmsSecretsSecret[] SecretInput
        {
            get => GetInstanceProperty<aws.IDataAwsKmsSecretsSecret[]>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsKmsSecretsSecret\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsKmsSecretsSecret[] Secret
        {
            get => GetInstanceProperty<aws.IDataAwsKmsSecretsSecret[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
