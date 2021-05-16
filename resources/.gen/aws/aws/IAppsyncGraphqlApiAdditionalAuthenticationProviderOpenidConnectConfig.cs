using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig), fullyQualifiedName: "aws.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig")]
    public interface IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig
    {
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        string Issuer
        {
            get;
        }

        [JsiiProperty(name: "authTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AuthTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "iatTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IatTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig), fullyQualifiedName: "aws.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
            public string Issuer
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "authTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AuthTtl
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "iatTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IatTtl
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
