using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafXssMatchSetXssMatchTuples")]
    public class WafXssMatchSetXssMatchTuples : aws.IWafXssMatchSetXssMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafXssMatchSetXssMatchTuplesFieldToMatch\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafXssMatchSetXssMatchTuplesFieldToMatch[] FieldToMatch
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
