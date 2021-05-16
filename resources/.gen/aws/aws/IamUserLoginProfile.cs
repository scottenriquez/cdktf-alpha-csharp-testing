using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.IamUserLoginProfile), fullyQualifiedName: "aws.IamUserLoginProfile", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.IamUserLoginProfileConfig\"}}]")]
    public class IamUserLoginProfile : HashiCorp.Cdktf.TerraformResource
    {
        public IamUserLoginProfile(Constructs.Construct scope, string id, aws.IIamUserLoginProfileConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IamUserLoginProfile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IamUserLoginProfile(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPasswordLength")]
        public virtual void ResetPasswordLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordResetRequired")]
        public virtual void ResetPasswordResetRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "encryptedPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptedPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyFingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pgpKeyInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PgpKeyInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PasswordLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordResetRequiredInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? PasswordResetRequiredInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "passwordLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasswordLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwordResetRequired", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool PasswordResetRequired
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pgpKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PgpKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string User
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
