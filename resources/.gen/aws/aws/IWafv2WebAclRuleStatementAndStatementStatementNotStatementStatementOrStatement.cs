using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement[] Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement[] Statement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement[]>()!;
            }
        }
    }
}
