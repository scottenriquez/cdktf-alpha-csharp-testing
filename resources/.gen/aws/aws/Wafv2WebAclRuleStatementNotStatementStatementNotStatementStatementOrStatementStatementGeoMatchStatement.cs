using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement")]
    public class Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement : aws.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement
    {
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] CountryCodes
        {
            get;
            set;
        }
    }
}
