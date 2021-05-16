using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncGraphqlApiAdditionalAuthenticationProvider), fullyQualifiedName: "aws.AppsyncGraphqlApiAdditionalAuthenticationProvider")]
    public interface IAppsyncGraphqlApiAdditionalAuthenticationProvider
    {
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthenticationType
        {
            get;
        }

        /// <summary>openid_connect_config block.</summary>
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig[]? OpenidConnectConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_pool_config block.</summary>
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig[]? UserPoolConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncGraphqlApiAdditionalAuthenticationProvider), fullyQualifiedName: "aws.AppsyncGraphqlApiAdditionalAuthenticationProvider")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthenticationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>openid_connect_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig[]? OpenidConnectConfig
            {
                get => GetInstanceProperty<aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig[]?>();
            }

            /// <summary>user_pool_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userPoolConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig[]? UserPoolConfig
            {
                get => GetInstanceProperty<aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig[]?>();
            }
        }
    }
}
