using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoIdentityPoolConfig), fullyQualifiedName: "aws.CognitoIdentityPoolConfig")]
    public interface ICognitoIdentityPoolConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "identityPoolName", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityPoolName
        {
            get;
        }

        [JsiiProperty(name: "allowUnauthenticatedIdentities", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowUnauthenticatedIdentities
        {
            get
            {
                return null;
            }
        }

        /// <summary>cognito_identity_providers block.</summary>
        [JsiiProperty(name: "cognitoIdentityProviders", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoIdentityPoolCognitoIdentityProviders\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICognitoIdentityPoolCognitoIdentityProviders[]? CognitoIdentityProviders
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "developerProviderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeveloperProviderName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "openidConnectProviderArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OpenidConnectProviderArns
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "samlProviderArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SamlProviderArns
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "supportedLoginProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SupportedLoginProviders
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

        [JsiiTypeProxy(nativeType: typeof(ICognitoIdentityPoolConfig), fullyQualifiedName: "aws.CognitoIdentityPoolConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoIdentityPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "identityPoolName", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityPoolName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowUnauthenticatedIdentities", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowUnauthenticatedIdentities
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>cognito_identity_providers block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoIdentityProviders", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoIdentityPoolCognitoIdentityProviders\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICognitoIdentityPoolCognitoIdentityProviders[]? CognitoIdentityProviders
            {
                get => GetInstanceProperty<aws.ICognitoIdentityPoolCognitoIdentityProviders[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "developerProviderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeveloperProviderName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "openidConnectProviderArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OpenidConnectProviderArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "samlProviderArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SamlProviderArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "supportedLoginProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SupportedLoginProviders
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
