using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LbListenerRuleConfig")]
    public class LbListenerRuleConfig : aws.ILbListenerRuleConfig
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleAction\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ILbListenerRuleAction[] Action
        {
            get;
            set;
        }

        /// <summary>condition block.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleCondition\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ILbListenerRuleCondition[] Condition
        {
            get;
            set;
        }

        [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ListenerArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
