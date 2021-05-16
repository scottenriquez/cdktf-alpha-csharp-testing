using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LbListenerRuleAction")]
    public class LbListenerRuleAction : aws.ILbListenerRuleAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>authenticate_cognito block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionAuthenticateCognito\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleActionAuthenticateCognito[]? AuthenticateCognito
        {
            get;
            set;
        }

        /// <summary>authenticate_oidc block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionAuthenticateOidc\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleActionAuthenticateOidc[]? AuthenticateOidc
        {
            get;
            set;
        }

        /// <summary>fixed_response block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionFixedResponse\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleActionFixedResponse[]? FixedResponse
        {
            get;
            set;
        }

        /// <summary>forward block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionForward\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleActionForward[]? Forward
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
        [JsiiProperty(name: "redirect", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionRedirect\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleActionRedirect[]? Redirect
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
