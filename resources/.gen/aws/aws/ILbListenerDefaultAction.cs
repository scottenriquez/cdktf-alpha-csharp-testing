using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerDefaultAction), fullyQualifiedName: "aws.LbListenerDefaultAction")]
    public interface ILbListenerDefaultAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>authenticate_cognito block.</summary>
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerDefaultActionAuthenticateCognito[]? AuthenticateCognito
        {
            get
            {
                return null;
            }
        }

        /// <summary>authenticate_oidc block.</summary>
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerDefaultActionAuthenticateOidc[]? AuthenticateOidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_response block.</summary>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerDefaultActionFixedResponse[]? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionForward\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerDefaultActionForward[]? Forward
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
        [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionRedirect\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerDefaultActionRedirect[]? Redirect
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

        [JsiiTypeProxy(nativeType: typeof(ILbListenerDefaultAction), fullyQualifiedName: "aws.LbListenerDefaultAction")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerDefaultAction
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
            [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerDefaultActionAuthenticateCognito[]? AuthenticateCognito
            {
                get => GetInstanceProperty<aws.ILbListenerDefaultActionAuthenticateCognito[]?>();
            }

            /// <summary>authenticate_oidc block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerDefaultActionAuthenticateOidc[]? AuthenticateOidc
            {
                get => GetInstanceProperty<aws.ILbListenerDefaultActionAuthenticateOidc[]?>();
            }

            /// <summary>fixed_response block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerDefaultActionFixedResponse[]? FixedResponse
            {
                get => GetInstanceProperty<aws.ILbListenerDefaultActionFixedResponse[]?>();
            }

            /// <summary>forward block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionForward\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerDefaultActionForward[]? Forward
            {
                get => GetInstanceProperty<aws.ILbListenerDefaultActionForward[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>redirect block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionRedirect\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerDefaultActionRedirect[]? Redirect
            {
                get => GetInstanceProperty<aws.ILbListenerDefaultActionRedirect[]?>();
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
