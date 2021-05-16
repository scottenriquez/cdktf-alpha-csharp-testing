using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement")]
    public interface IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatement
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
