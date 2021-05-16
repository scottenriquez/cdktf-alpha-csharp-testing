using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AlbListenerRuleActionAuthenticateCognito")]
    public class AlbListenerRuleActionAuthenticateCognito : aws.IAlbListenerRuleActionAuthenticateCognito
    {
        [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPoolArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "userPoolClientId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPoolClientId
        {
            get;
            set;
        }

        [JsiiProperty(name: "userPoolDomain", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPoolDomain
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
