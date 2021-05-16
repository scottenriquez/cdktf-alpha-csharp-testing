using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatementSqliMatchStatementTextTransformation), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatementSqliMatchStatementTextTransformation")]
    public interface IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatementSqliMatchStatementTextTransformation
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

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatementSqliMatchStatementTextTransformation), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatementSqliMatchStatementTextTransformation")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatementSqliMatchStatementTextTransformation
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
