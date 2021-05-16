using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafSqlInjectionMatchSetSqlInjectionMatchTuples")]
    public class WafSqlInjectionMatchSetSqlInjectionMatchTuples : aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch[] FieldToMatch
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
