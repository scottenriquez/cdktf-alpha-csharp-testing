using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAlbListenerDefaultAction), fullyQualifiedName: "aws.AlbListenerDefaultAction")]
    public interface IAlbListenerDefaultAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>authenticate_cognito block.</summary>
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerDefaultActionAuthenticateCognito[]? AuthenticateCognito
        {
            get
            {
                return null;
            }
        }

        /// <summary>authenticate_oidc block.</summary>
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerDefaultActionAuthenticateOidc[]? AuthenticateOidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_response block.</summary>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerDefaultActionFixedResponse[]? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionForward\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerDefaultActionForward[]? Forward
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
        [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionRedirect\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerDefaultActionRedirect[]? Redirect
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

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerDefaultAction), fullyQualifiedName: "aws.AlbListenerDefaultAction")]
        internal sealed class _Proxy : DeputyBase, aws.IAlbListenerDefaultAction
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
            [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerDefaultActionAuthenticateCognito[]? AuthenticateCognito
            {
                get => GetInstanceProperty<aws.IAlbListenerDefaultActionAuthenticateCognito[]?>();
            }

            /// <summary>authenticate_oidc block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerDefaultActionAuthenticateOidc[]? AuthenticateOidc
            {
                get => GetInstanceProperty<aws.IAlbListenerDefaultActionAuthenticateOidc[]?>();
            }

            /// <summary>fixed_response block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerDefaultActionFixedResponse[]? FixedResponse
            {
                get => GetInstanceProperty<aws.IAlbListenerDefaultActionFixedResponse[]?>();
            }

            /// <summary>forward block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionForward\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerDefaultActionForward[]? Forward
            {
                get => GetInstanceProperty<aws.IAlbListenerDefaultActionForward[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>redirect block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionRedirect\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerDefaultActionRedirect[]? Redirect
            {
                get => GetInstanceProperty<aws.IAlbListenerDefaultActionRedirect[]?>();
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
