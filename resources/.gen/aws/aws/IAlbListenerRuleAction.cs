using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleAction), fullyQualifiedName: "aws.AlbListenerRuleAction")]
    public interface IAlbListenerRuleAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>authenticate_cognito block.</summary>
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleActionAuthenticateCognito[]? AuthenticateCognito
        {
            get
            {
                return null;
            }
        }

        /// <summary>authenticate_oidc block.</summary>
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleActionAuthenticateOidc[]? AuthenticateOidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_response block.</summary>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleActionFixedResponse[]? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionForward\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleActionForward[]? Forward
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Order
        {
            get
            {
                return null;
            }
        }

        /// <summary>redirect block.</summary>
        [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionRedirect\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleActionRedirect[]? Redirect
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleAction), fullyQualifiedName: "aws.AlbListenerRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.IAlbListenerRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authenticate_cognito block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleActionAuthenticateCognito[]? AuthenticateCognito
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleActionAuthenticateCognito[]?>();
            }

            /// <summary>authenticate_oidc block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleActionAuthenticateOidc[]? AuthenticateOidc
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleActionAuthenticateOidc[]?>();
            }

            /// <summary>fixed_response block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleActionFixedResponse[]? FixedResponse
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleActionFixedResponse[]?>();
            }

            /// <summary>forward block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionForward\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleActionForward[]? Forward
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleActionForward[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>redirect block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionRedirect\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleActionRedirect[]? Redirect
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleActionRedirect[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetGroupArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
