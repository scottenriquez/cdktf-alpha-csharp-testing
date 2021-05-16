using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclRule), fullyQualifiedName: "aws.WafregionalWebAclRule")]
    public interface IWafregionalWebAclRule
    {
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

        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclRuleAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafregionalWebAclRuleAction[]? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>override_action block.</summary>
        [JsiiProperty(name: "overrideAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclRuleOverrideAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafregionalWebAclRuleOverrideAction[]? OverrideAction
        {
            get
            {
                return null;
            }
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

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclRule), fullyQualifiedName: "aws.WafregionalWebAclRule")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalWebAclRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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

            /// <summary>action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclRuleAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafregionalWebAclRuleAction[]? Action
            {
                get => GetInstanceProperty<aws.IWafregionalWebAclRuleAction[]?>();
            }

            /// <summary>override_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overrideAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclRuleOverrideAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafregionalWebAclRuleOverrideAction[]? OverrideAction
            {
                get => GetInstanceProperty<aws.IWafregionalWebAclRuleOverrideAction[]?>();
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
