using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafByteMatchSetByteMatchTuples")]
    public class WafByteMatchSetByteMatchTuples : aws.IWafByteMatchSetByteMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafByteMatchSetByteMatchTuplesFieldToMatch\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafByteMatchSetByteMatchTuplesFieldToMatch[] FieldToMatch
        {
            get;
            set;
        }

        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PositionalConstraint
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

        [JsiiOptional]
        [JsiiProperty(name: "targetString", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TargetString
        {
            get;
            set;
        }
    }
}
