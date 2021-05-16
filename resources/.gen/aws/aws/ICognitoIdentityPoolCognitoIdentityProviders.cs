using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoIdentityPoolCognitoIdentityProviders), fullyQualifiedName: "aws.CognitoIdentityPoolCognitoIdentityProviders")]
    public interface ICognitoIdentityPoolCognitoIdentityProviders
    {
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProviderName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "serverSideTokenCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ServerSideTokenCheck
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoIdentityPoolCognitoIdentityProviders), fullyQualifiedName: "aws.CognitoIdentityPoolCognitoIdentityProviders")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoIdentityPoolCognitoIdentityProviders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProviderName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "serverSideTokenCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ServerSideTokenCheck
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
