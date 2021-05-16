using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleActionAuthenticateCognito), fullyQualifiedName: "aws.LbListenerRuleActionAuthenticateCognito")]
    public interface ILbListenerRuleActionAuthenticateCognito
    {
        [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolArn
        {
            get;
        }

        [JsiiProperty(name: "userPoolClientId", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolClientId
        {
            get;
        }

        [JsiiProperty(name: "userPoolDomain", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolDomain
        {
            get;
        }

        [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AuthenticationRequestExtraParams
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnUnauthenticatedRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionCookieName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SessionTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleActionAuthenticateCognito), fullyQualifiedName: "aws.LbListenerRuleActionAuthenticateCognito")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerRuleActionAuthenticateCognito
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "userPoolClientId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "userPoolDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolDomain
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AuthenticationRequestExtraParams
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnUnauthenticatedRequest
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionCookieName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SessionTimeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
