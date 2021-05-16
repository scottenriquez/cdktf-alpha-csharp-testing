using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafregionalRegexMatchSetRegexMatchTuple")]
    public class WafregionalRegexMatchSetRegexMatchTuple : aws.IWafregionalRegexMatchSetRegexMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalRegexMatchSetRegexMatchTupleFieldToMatch\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch[] FieldToMatch
        {
            get;
            set;
        }

        [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RegexPatternSetId
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
