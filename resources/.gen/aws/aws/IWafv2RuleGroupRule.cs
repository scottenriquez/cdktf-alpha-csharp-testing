using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRule), fullyQualifiedName: "aws.Wafv2RuleGroupRule")]
    public interface IWafv2RuleGroupRule
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleAction\"},\"kind\":\"array\"}}")]
        aws.IWafv2RuleGroupRuleAction[] Action
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatement\"},\"kind\":\"array\"}}")]
        aws.IWafv2RuleGroupRuleStatement[] Statement
        {
            get;
        }

        /// <summary>visibility_config block.</summary>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleVisibilityConfig\"},\"kind\":\"array\"}}")]
        aws.IWafv2RuleGroupRuleVisibilityConfig[] VisibilityConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRule), fullyQualifiedName: "aws.Wafv2RuleGroupRule")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleAction\"},\"kind\":\"array\"}}")]
            public aws.IWafv2RuleGroupRuleAction[] Action
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleAction[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>statement block.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatement\"},\"kind\":\"array\"}}")]
            public aws.IWafv2RuleGroupRuleStatement[] Statement
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatement[]>()!;
            }

            /// <summary>visibility_config block.</summary>
            [JsiiProperty(name: "visibilityConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleVisibilityConfig\"},\"kind\":\"array\"}}")]
            public aws.IWafv2RuleGroupRuleVisibilityConfig[] VisibilityConfig
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleVisibilityConfig[]>()!;
            }
        }
    }
}
