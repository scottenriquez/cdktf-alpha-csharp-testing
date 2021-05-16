using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementGeoMatchStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementGeoMatchStatement")]
    public interface IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementGeoMatchStatement
    {
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CountryCodes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementGeoMatchStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementGeoMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementGeoMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CountryCodes
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
