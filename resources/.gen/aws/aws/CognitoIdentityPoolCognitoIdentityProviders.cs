using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CognitoIdentityPoolCognitoIdentityProviders")]
    public class CognitoIdentityPoolCognitoIdentityProviders : aws.ICognitoIdentityPoolCognitoIdentityProviders
    {
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ClientId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ProviderName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideTokenCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ServerSideTokenCheck
        {
            get;
            set;
        }
    }
}
