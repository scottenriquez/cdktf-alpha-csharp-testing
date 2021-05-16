using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementIpSetReferenceStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementIpSetReferenceStatement")]
    public interface IWafv2RuleGroupRuleStatementIpSetReferenceStatement
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementIpSetReferenceStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementIpSetReferenceStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupRuleStatementIpSetReferenceStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
