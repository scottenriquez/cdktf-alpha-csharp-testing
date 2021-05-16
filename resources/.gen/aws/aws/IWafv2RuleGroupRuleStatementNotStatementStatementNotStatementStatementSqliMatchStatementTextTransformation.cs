using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation")]
    public interface IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation
    {
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
