using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig), fullyQualifiedName: "aws.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig")]
    public interface IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig
    {
        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolId
        {
            get;
        }

        [JsiiProperty(name: "appIdClientRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppIdClientRegex
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsRegion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig), fullyQualifiedName: "aws.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "appIdClientRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppIdClientRegex
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsRegion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
