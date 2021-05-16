using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalRuleGroupActivatedRule), fullyQualifiedName: "aws.WafregionalRuleGroupActivatedRule")]
    public interface IWafregionalRuleGroupActivatedRule
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalRuleGroupActivatedRuleAction\"},\"kind\":\"array\"}}")]
        aws.IWafregionalRuleGroupActivatedRuleAction[] Action
        {
            get;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        string RuleId
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalRuleGroupActivatedRule), fullyQualifiedName: "aws.WafregionalRuleGroupActivatedRule")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalRuleGroupActivatedRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalRuleGroupActivatedRuleAction\"},\"kind\":\"array\"}}")]
            public aws.IWafregionalRuleGroupActivatedRuleAction[] Action
            {
                get => GetInstanceProperty<aws.IWafregionalRuleGroupActivatedRuleAction[]>()!;
            }

            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
