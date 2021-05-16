using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementNotStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementNotStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatement[] Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementNotStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatement[] Statement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatement[]>()!;
            }
        }
    }
}
