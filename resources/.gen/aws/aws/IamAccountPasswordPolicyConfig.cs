using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.IamAccountPasswordPolicyConfig")]
    public class IamAccountPasswordPolicyConfig : aws.IIamAccountPasswordPolicyConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "allowUsersToChangePassword", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowUsersToChangePassword
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hardExpiry", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? HardExpiry
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPasswordAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxPasswordAge
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumPasswordLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinimumPasswordLength
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordReusePrevention", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PasswordReusePrevention
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireLowercaseCharacters", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequireLowercaseCharacters
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireNumbers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequireNumbers
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireSymbols", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequireSymbols
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireUppercaseCharacters", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequireUppercaseCharacters
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
