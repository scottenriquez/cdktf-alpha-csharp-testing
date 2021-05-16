using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsKmsSecret), fullyQualifiedName: "aws.DataAwsKmsSecret", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsKmsSecretConfig\"}}]")]
    public class DataAwsKmsSecret : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsKmsSecret(Constructs.Construct scope, string id, aws.IDataAwsKmsSecretConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsSecret(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsSecret(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "secretInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsKmsSecretSecret\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsKmsSecretSecret[] SecretInput
        {
            get => GetInstanceProperty<aws.IDataAwsKmsSecretSecret[]>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsKmsSecretSecret\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsKmsSecretSecret[] Secret
        {
            get => GetInstanceProperty<aws.IDataAwsKmsSecretSecret[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
