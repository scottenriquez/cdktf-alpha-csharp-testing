using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleAction), fullyQualifiedName: "aws.LbListenerRuleAction")]
    public interface ILbListenerRuleAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>authenticate_cognito block.</summary>
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleActionAuthenticateCognito[]? AuthenticateCognito
        {
            get
            {
                return null;
            }
        }

        /// <summary>authenticate_oidc block.</summary>
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleActionAuthenticateOidc[]? AuthenticateOidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_response block.</summary>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleActionFixedResponse[]? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionForward\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleActionForward[]? Forward
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
        [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionRedirect\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleActionRedirect[]? Redirect
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

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleAction), fullyQualifiedName: "aws.LbListenerRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerRuleAction
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
            [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleActionAuthenticateCognito[]? AuthenticateCognito
            {
                get => GetInstanceProperty<aws.ILbListenerRuleActionAuthenticateCognito[]?>();
            }

            /// <summary>authenticate_oidc block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleActionAuthenticateOidc[]? AuthenticateOidc
            {
                get => GetInstanceProperty<aws.ILbListenerRuleActionAuthenticateOidc[]?>();
            }

            /// <summary>fixed_response block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleActionFixedResponse[]? FixedResponse
            {
                get => GetInstanceProperty<aws.ILbListenerRuleActionFixedResponse[]?>();
            }

            /// <summary>forward block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionForward\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleActionForward[]? Forward
            {
                get => GetInstanceProperty<aws.ILbListenerRuleActionForward[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>redirect block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionRedirect\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleActionRedirect[]? Redirect
            {
                get => GetInstanceProperty<aws.ILbListenerRuleActionRedirect[]?>();
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
