using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument")]
    public interface IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
