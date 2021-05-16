using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncGraphqlApiConfig), fullyQualifiedName: "aws.AppsyncGraphqlApiConfig")]
    public interface IAppsyncGraphqlApiConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthenticationType
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>additional_authentication_provider block.</summary>
        [JsiiProperty(name: "additionalAuthenticationProvider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider[]? AdditionalAuthenticationProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_config block.</summary>
        [JsiiProperty(name: "logConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiLogConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncGraphqlApiLogConfig[]? LogConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>openid_connect_config block.</summary>
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiOpenidConnectConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncGraphqlApiOpenidConnectConfig[]? OpenidConnectConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Schema
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

        /// <summary>user_pool_config block.</summary>
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiUserPoolConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncGraphqlApiUserPoolConfig[]? UserPoolConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "xrayEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? XrayEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncGraphqlApiConfig), fullyQualifiedName: "aws.AppsyncGraphqlApiConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncGraphqlApiConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthenticationType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_authentication_provider block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalAuthenticationProvider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider[]? AdditionalAuthenticationProvider
            {
                get => GetInstanceProperty<aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider[]?>();
            }

            /// <summary>log_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiLogConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncGraphqlApiLogConfig[]? LogConfig
            {
                get => GetInstanceProperty<aws.IAppsyncGraphqlApiLogConfig[]?>();
            }

            /// <summary>openid_connect_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiOpenidConnectConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncGraphqlApiOpenidConnectConfig[]? OpenidConnectConfig
            {
                get => GetInstanceProperty<aws.IAppsyncGraphqlApiOpenidConnectConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Schema
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>user_pool_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userPoolConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiUserPoolConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncGraphqlApiUserPoolConfig[]? UserPoolConfig
            {
                get => GetInstanceProperty<aws.IAppsyncGraphqlApiUserPoolConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "xrayEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? XrayEnabled
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
