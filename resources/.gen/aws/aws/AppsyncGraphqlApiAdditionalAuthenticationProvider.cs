using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppsyncGraphqlApiAdditionalAuthenticationProvider")]
    public class AppsyncGraphqlApiAdditionalAuthenticationProvider : aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider
    {
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AuthenticationType
        {
            get;
            set;
        }

        /// <summary>openid_connect_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig[]? OpenidConnectConfig
        {
            get;
            set;
        }

        /// <summary>user_pool_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig[]? UserPoolConfig
        {
            get;
            set;
        }
    }
}
