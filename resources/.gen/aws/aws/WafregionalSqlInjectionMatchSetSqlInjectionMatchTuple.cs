using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTuple")]
    public class WafregionalSqlInjectionMatchSetSqlInjectionMatchTuple : aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch[] FieldToMatch
        {
            get;
            set;
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TextTransformation
        {
            get;
            set;
        }
    }
}
