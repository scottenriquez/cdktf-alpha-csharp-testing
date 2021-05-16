using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafRuleGroupActivatedRule), fullyQualifiedName: "aws.WafRuleGroupActivatedRule")]
    public interface IWafRuleGroupActivatedRule
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafRuleGroupActivatedRuleAction\"},\"kind\":\"array\"}}")]
        aws.IWafRuleGroupActivatedRuleAction[] Action
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

        [JsiiTypeProxy(nativeType: typeof(IWafRuleGroupActivatedRule), fullyQualifiedName: "aws.WafRuleGroupActivatedRule")]
        internal sealed class _Proxy : DeputyBase, aws.IWafRuleGroupActivatedRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafRuleGroupActivatedRuleAction\"},\"kind\":\"array\"}}")]
            public aws.IWafRuleGroupActivatedRuleAction[] Action
            {
                get => GetInstanceProperty<aws.IWafRuleGroupActivatedRuleAction[]>()!;
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
