using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleAction), fullyQualifiedName: "aws.Wafv2RuleGroupRuleAction")]
    public interface IWafv2RuleGroupRuleAction
    {
        /// <summary>allow block.</summary>
        [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleActionAllow\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleActionAllow[]? Allow
        {
            get
            {
                return null;
            }
        }

        /// <summary>block block.</summary>
        [JsiiProperty(name: "block", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleActionBlock\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleActionBlock[]? Block
        {
            get
            {
                return null;
            }
        }

        /// <summary>count block.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleActionCount\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleActionCount[]? Count
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleAction), fullyQualifiedName: "aws.Wafv2RuleGroupRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allow block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleActionAllow\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleActionAllow[]? Allow
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleActionAllow[]?>();
            }

            /// <summary>block block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "block", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleActionBlock\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleActionBlock[]? Block
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleActionBlock[]?>();
            }

            /// <summary>count block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleActionCount\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleActionCount[]? Count
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleActionCount[]?>();
            }
        }
    }
}
