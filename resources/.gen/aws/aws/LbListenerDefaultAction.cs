using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LbListenerDefaultAction")]
    public class LbListenerDefaultAction : aws.ILbListenerDefaultAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>authenticate_cognito block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerDefaultActionAuthenticateCognito[]? AuthenticateCognito
        {
            get;
            set;
        }

        /// <summary>authenticate_oidc block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerDefaultActionAuthenticateOidc[]? AuthenticateOidc
        {
            get;
            set;
        }

        /// <summary>fixed_response block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerDefaultActionFixedResponse[]? FixedResponse
        {
            get;
            set;
        }

        /// <summary>forward block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionForward\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerDefaultActionForward[]? Forward
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
        [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionRedirect\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerDefaultActionRedirect[]? Redirect
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
