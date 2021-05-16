using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement")]
    public interface IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatement\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatement[] Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatement\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatement[] Statement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatement[]>()!;
            }
        }
    }
}
