using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AlbListenerRuleAction")]
    public class AlbListenerRuleAction : aws.IAlbListenerRuleAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>authenticate_cognito block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleActionAuthenticateCognito[]? AuthenticateCognito
        {
            get;
            set;
        }

        /// <summary>authenticate_oidc block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleActionAuthenticateOidc[]? AuthenticateOidc
        {
            get;
            set;
        }

        /// <summary>fixed_response block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleActionFixedResponse[]? FixedResponse
        {
            get;
            set;
        }

        /// <summary>forward block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionForward\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleActionForward[]? Forward
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
        [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionRedirect\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleActionRedirect[]? Redirect
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
