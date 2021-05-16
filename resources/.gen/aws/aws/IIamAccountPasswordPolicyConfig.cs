using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIamAccountPasswordPolicyConfig), fullyQualifiedName: "aws.IamAccountPasswordPolicyConfig")]
    public interface IIamAccountPasswordPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "allowUsersToChangePassword", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowUsersToChangePassword
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "hardExpiry", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? HardExpiry
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxPasswordAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPasswordAge
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minimumPasswordLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumPasswordLength
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "passwordReusePrevention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PasswordReusePrevention
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requireLowercaseCharacters", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequireLowercaseCharacters
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requireNumbers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequireNumbers
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requireSymbols", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequireSymbols
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requireUppercaseCharacters", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequireUppercaseCharacters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIamAccountPasswordPolicyConfig), fullyQualifiedName: "aws.IamAccountPasswordPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IIamAccountPasswordPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowUsersToChangePassword", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowUsersToChangePassword
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "hardExpiry", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? HardExpiry
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxPasswordAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPasswordAge
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minimumPasswordLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumPasswordLength
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "passwordReusePrevention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordReusePrevention
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requireLowercaseCharacters", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequireLowercaseCharacters
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requireNumbers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequireNumbers
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requireSymbols", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequireSymbols
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requireUppercaseCharacters", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequireUppercaseCharacters
            {
                get => GetInstanceProperty<bool?>();
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
