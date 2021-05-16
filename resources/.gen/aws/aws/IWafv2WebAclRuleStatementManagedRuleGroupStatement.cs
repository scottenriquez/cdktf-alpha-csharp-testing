using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementManagedRuleGroupStatement")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatement
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
        string VendorName
        {
            get;
        }

        /// <summary>excluded_rule block.</summary>
        [JsiiProperty(name: "excludedRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule[]? ExcludedRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementManagedRuleGroupStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementManagedRuleGroupStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
            public string VendorName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>excluded_rule block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule[]? ExcludedRule
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule[]?>();
            }
        }
    }
}
