using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementByteMatchStatementTextTransformation")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementByteMatchStatementTextTransformation : aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementByteMatchStatementTextTransformation
    {
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Priority
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }
    }
}
