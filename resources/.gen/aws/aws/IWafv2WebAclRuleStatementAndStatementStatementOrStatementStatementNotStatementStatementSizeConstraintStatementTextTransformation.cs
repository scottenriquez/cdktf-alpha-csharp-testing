using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation
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

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation
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
