using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRuleGroupReferenceStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRuleGroupReferenceStatement")]
    public interface IWafv2WebAclRuleStatementRuleGroupReferenceStatement
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>excluded_rule block.</summary>
        [JsiiProperty(name: "excludedRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule[]? ExcludedRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRuleGroupReferenceStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRuleGroupReferenceStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementRuleGroupReferenceStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>excluded_rule block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule[]? ExcludedRule
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule[]?>();
            }
        }
    }
}
