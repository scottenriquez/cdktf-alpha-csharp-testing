using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatementTextTransformation")]
    public class Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatementTextTransformation : aws.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatementTextTransformation
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
