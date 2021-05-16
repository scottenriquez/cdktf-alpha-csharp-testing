using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CognitoUserPoolConfig")]
    public class CognitoUserPoolConfig : aws.ICognitoUserPoolConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>admin_create_user_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolAdminCreateUserConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolAdminCreateUserConfig[]? AdminCreateUserConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AliasAttributes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AutoVerifiedAttributes
        {
            get;
            set;
        }

        /// <summary>device_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolDeviceConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolDeviceConfiguration[]? DeviceConfiguration
        {
            get;
            set;
        }

        /// <summary>email_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolEmailConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolEmailConfiguration[]? EmailConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmailVerificationMessage
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmailVerificationSubject
        {
            get;
            set;
        }

        /// <summary>lambda_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolLambdaConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolLambdaConfig[]? LambdaConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MfaConfiguration
        {
            get;
            set;
        }

        /// <summary>password_policy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolPasswordPolicy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolPasswordPolicy[]? PasswordPolicy
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSchema\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolSchema[]? Schema
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SmsAuthenticationMessage
        {
            get;
            set;
        }

        /// <summary>sms_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smsConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSmsConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolSmsConfiguration[]? SmsConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SmsVerificationMessage
        {
            get;
            set;
        }

        /// <summary>software_token_mfa_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolSoftwareTokenMfaConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolSoftwareTokenMfaConfiguration[]? SoftwareTokenMfaConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? UsernameAttributes
        {
            get;
            set;
        }

        /// <summary>username_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUsernameConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolUsernameConfiguration[]? UsernameConfiguration
        {
            get;
            set;
        }

        /// <summary>user_pool_add_ons block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolUserPoolAddOns\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolUserPoolAddOns[]? UserPoolAddOns
        {
            get;
            set;
        }

        /// <summary>verification_message_template block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoUserPoolVerificationMessageTemplate\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICognitoUserPoolVerificationMessageTemplate[]? VerificationMessageTemplate
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
