using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AlbListenerDefaultAction")]
    public class AlbListenerDefaultAction : aws.IAlbListenerDefaultAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>authenticate_cognito block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerDefaultActionAuthenticateCognito[]? AuthenticateCognito
        {
            get;
            set;
        }

        /// <summary>authenticate_oidc block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerDefaultActionAuthenticateOidc[]? AuthenticateOidc
        {
            get;
            set;
        }

        /// <summary>fixed_response block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerDefaultActionFixedResponse[]? FixedResponse
        {
            get;
            set;
        }

        /// <summary>forward block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionForward\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerDefaultActionForward[]? Forward
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Order
        {
            get;
            set;
        }

        /// <summary>redirect block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionRedirect\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerDefaultActionRedirect[]? Redirect
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TargetGroupArn
        {
            get;
            set;
        }
    }
}
