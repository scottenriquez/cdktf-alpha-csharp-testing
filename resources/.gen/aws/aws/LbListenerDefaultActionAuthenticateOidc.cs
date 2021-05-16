using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LbListenerDefaultActionAuthenticateOidc")]
    public class LbListenerDefaultActionAuthenticateOidc : aws.ILbListenerDefaultActionAuthenticateOidc
    {
        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AuthorizationEndpoint
        {
            get;
            set;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClientId
        {
            get;
            set;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClientSecret
        {
            get;
            set;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Issuer
        {
            get;
            set;
        }

        [JsiiProperty(name: "tokenEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TokenEndpoint
        {
            get;
            set;
        }

        [JsiiProperty(name: "userInfoEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserInfoEndpoint
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? AuthenticationRequestExtraParams
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OnUnauthenticatedRequest
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Scope
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SessionCookieName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? SessionTimeout
        {
            get;
            set;
        }
    }
}
