using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolConfig), fullyQualifiedName: "aws.CognitoUserPoolConfig")]
    public interface ICognitoUserPoolConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>admin_create_user_config block.</summary>
        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolAdminCreateUserConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolAdminCreateUserConfig[]? AdminCreateUserConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AliasAttributes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AutoVerifiedAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>device_configuration block.</summary>
        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolDeviceConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolDeviceConfiguration[]? DeviceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>email_configuration block.</summary>
        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolEmailConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolEmailConfiguration[]? EmailConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailVerificationMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailVerificationSubject
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_config block.</summary>
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolLambdaConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolLambdaConfig[]? LambdaConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MfaConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>password_policy block.</summary>
        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolPasswordPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolPasswordPolicy[]? PasswordPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema block.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchema\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolSchema[]? Schema
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmsAuthenticationMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>sms_configuration block.</summary>
        [JsiiProperty(name: "smsConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSmsConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolSmsConfiguration[]? SmsConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmsVerificationMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>software_token_mfa_configuration block.</summary>
        [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSoftwareTokenMfaConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolSoftwareTokenMfaConfiguration[]? SoftwareTokenMfaConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UsernameAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>username_configuration block.</summary>
        [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUsernameConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolUsernameConfiguration[]? UsernameConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_pool_add_ons block.</summary>
        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUserPoolAddOns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolUserPoolAddOns[]? UserPoolAddOns
        {
            get
            {
                return null;
            }
        }

        /// <summary>verification_message_template block.</summary>
        [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolVerificationMessageTemplate\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoUserPoolVerificationMessageTemplate[]? VerificationMessageTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolConfig), fullyQualifiedName: "aws.CognitoUserPoolConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>admin_create_user_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolAdminCreateUserConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolAdminCreateUserConfig[]? AdminCreateUserConfig
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolAdminCreateUserConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AliasAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AutoVerifiedAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>device_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolDeviceConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolDeviceConfiguration[]? DeviceConfiguration
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolDeviceConfiguration[]?>();
            }

            /// <summary>email_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolEmailConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolEmailConfiguration[]? EmailConfiguration
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolEmailConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailVerificationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailVerificationSubject
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lambda_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolLambdaConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolLambdaConfig[]? LambdaConfig
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolLambdaConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MfaConfiguration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>password_policy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolPasswordPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolPasswordPolicy[]? PasswordPolicy
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolPasswordPolicy[]?>();
            }

            /// <summary>schema block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchema\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolSchema[]? Schema
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolSchema[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmsAuthenticationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>sms_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smsConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSmsConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolSmsConfiguration[]? SmsConfiguration
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolSmsConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmsVerificationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>software_token_mfa_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSoftwareTokenMfaConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolSoftwareTokenMfaConfiguration[]? SoftwareTokenMfaConfiguration
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolSoftwareTokenMfaConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UsernameAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>username_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUsernameConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolUsernameConfiguration[]? UsernameConfiguration
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolUsernameConfiguration[]?>();
            }

            /// <summary>user_pool_add_ons block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUserPoolAddOns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolUserPoolAddOns[]? UserPoolAddOns
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolUserPoolAddOns[]?>();
            }

            /// <summary>verification_message_template block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolVerificationMessageTemplate\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoUserPoolVerificationMessageTemplate[]? VerificationMessageTemplate
            {
                get => GetInstanceProperty<aws.ICognitoUserPoolVerificationMessageTemplate[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
