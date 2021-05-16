using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementGeoMatchStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementGeoMatchStatement")]
    public interface IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementGeoMatchStatement
    {
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CountryCodes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementGeoMatchStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementGeoMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementGeoMatchStatement
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
