using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CognitoUserPool), fullyQualifiedName: "aws.CognitoUserPool", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CognitoUserPoolConfig\"}}]")]
    public class CognitoUserPool : HashiCorp.Cdktf.TerraformResource
    {
        public CognitoUserPool(Constructs.Construct scope, string id, aws.ICognitoUserPoolConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPool(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdminCreateUserConfig")]
        public virtual void ResetAdminCreateUserConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAliasAttributes")]
        public virtual void ResetAliasAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoVerifiedAttributes")]
        public virtual void ResetAutoVerifiedAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceConfiguration")]
        public virtual void ResetDeviceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailConfiguration")]
        public virtual void ResetEmailConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailVerificationMessage")]
        public virtual void ResetEmailVerificationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailVerificationSubject")]
        public virtual void ResetEmailVerificationSubject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaConfig")]
        public virtual void ResetLambdaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMfaConfiguration")]
        public virtual void ResetMfaConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordPolicy")]
        public virtual void ResetPasswordPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchema")]
        public virtual void ResetSchema()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsAuthenticationMessage")]
        public virtual void ResetSmsAuthenticationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsConfiguration")]
        public virtual void ResetSmsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsVerificationMessage")]
        public virtual void ResetSmsVerificationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftwareTokenMfaConfiguration")]
        public virtual void ResetSoftwareTokenMfaConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernameAttributes")]
        public virtual void ResetUsernameAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernameConfiguration")]
        public virtual void ResetUsernameConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPoolAddOns")]
        public virtual void ResetUserPoolAddOns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerificationMessageTemplate")]
        public virtual void ResetVerificationMessageTemplate()
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

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModifiedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminCreateUserConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolAdminCreateUserConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolAdminCreateUserConfig[]? AdminCreateUserConfigInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolAdminCreateUserConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AliasAttributesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoVerifiedAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AutoVerifiedAttributesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolDeviceConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolDeviceConfiguration[]? DeviceConfigurationInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolDeviceConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolEmailConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolEmailConfiguration[]? EmailConfigurationInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolEmailConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailVerificationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationSubjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailVerificationSubjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolLambdaConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolLambdaConfig[]? LambdaConfigInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolLambdaConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mfaConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MfaConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordPolicyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolPasswordPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolPasswordPolicy[]? PasswordPolicyInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolPasswordPolicy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchema\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolSchema[]? SchemaInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolSchema[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsAuthenticationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmsAuthenticationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSmsConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolSmsConfiguration[]? SmsConfigurationInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolSmsConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsVerificationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmsVerificationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareTokenMfaConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSoftwareTokenMfaConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolSoftwareTokenMfaConfiguration[]? SoftwareTokenMfaConfigurationInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolSoftwareTokenMfaConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? UsernameAttributesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUsernameConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolUsernameConfiguration[]? UsernameConfigurationInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolUsernameConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolAddOnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUserPoolAddOns\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolUserPoolAddOns[]? UserPoolAddOnsInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolUserPoolAddOns[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verificationMessageTemplateInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolVerificationMessageTemplate\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoUserPoolVerificationMessageTemplate[]? VerificationMessageTemplateInput
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolVerificationMessageTemplate[]?>();
        }

        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolAdminCreateUserConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolAdminCreateUserConfig[] AdminCreateUserConfig
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolAdminCreateUserConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AliasAttributes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AutoVerifiedAttributes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolDeviceConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolDeviceConfiguration[] DeviceConfiguration
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolDeviceConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolEmailConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolEmailConfiguration[] EmailConfiguration
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolEmailConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailVerificationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailVerificationSubject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolLambdaConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolLambdaConfig[] LambdaConfig
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolLambdaConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MfaConfiguration
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

        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolPasswordPolicy\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolPasswordPolicy[] PasswordPolicy
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolPasswordPolicy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchema\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolSchema[] Schema
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolSchema[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsAuthenticationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSmsConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolSmsConfiguration[] SmsConfiguration
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolSmsConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsVerificationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSoftwareTokenMfaConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolSoftwareTokenMfaConfiguration[] SoftwareTokenMfaConfiguration
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolSoftwareTokenMfaConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UsernameAttributes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUsernameConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolUsernameConfiguration[] UsernameConfiguration
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolUsernameConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUserPoolAddOns\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolUserPoolAddOns[] UserPoolAddOns
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolUserPoolAddOns[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolVerificationMessageTemplate\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoUserPoolVerificationMessageTemplate[] VerificationMessageTemplate
        {
            get => GetInstanceProperty<aws.ICognitoUserPoolVerificationMessageTemplate[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
