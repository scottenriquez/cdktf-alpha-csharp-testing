using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.IamAccountPasswordPolicy), fullyQualifiedName: "aws.IamAccountPasswordPolicy", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.IamAccountPasswordPolicyConfig\"}}]")]
    public class IamAccountPasswordPolicy : HashiCorp.Cdktf.TerraformResource
    {
        public IamAccountPasswordPolicy(Constructs.Construct scope, string id, aws.IIamAccountPasswordPolicyConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IamAccountPasswordPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IamAccountPasswordPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllowUsersToChangePassword")]
        public virtual void ResetAllowUsersToChangePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHardExpiry")]
        public virtual void ResetHardExpiry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxPasswordAge")]
        public virtual void ResetMaxPasswordAge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumPasswordLength")]
        public virtual void ResetMinimumPasswordLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordReusePrevention")]
        public virtual void ResetPasswordReusePrevention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireLowercaseCharacters")]
        public virtual void ResetRequireLowercaseCharacters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireNumbers")]
        public virtual void ResetRequireNumbers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireSymbols")]
        public virtual void ResetRequireSymbols()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireUppercaseCharacters")]
        public virtual void ResetRequireUppercaseCharacters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "expirePasswords", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ExpirePasswords
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowUsersToChangePasswordInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AllowUsersToChangePasswordInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hardExpiryInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? HardExpiryInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPasswordAgeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxPasswordAgeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumPasswordLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumPasswordLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordReusePreventionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PasswordReusePreventionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireLowercaseCharactersInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RequireLowercaseCharactersInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireNumbersInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RequireNumbersInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireSymbolsInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RequireSymbolsInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireUppercaseCharactersInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RequireUppercaseCharactersInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "allowUsersToChangePassword", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AllowUsersToChangePassword
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hardExpiry", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool HardExpiry
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxPasswordAge", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPasswordAge
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumPasswordLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumPasswordLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwordReusePrevention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasswordReusePrevention
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireLowercaseCharacters", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RequireLowercaseCharacters
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireNumbers", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RequireNumbers
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireSymbols", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RequireSymbols
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireUppercaseCharacters", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RequireUppercaseCharacters
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }
    }
}
