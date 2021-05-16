using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.WafregionalRegexMatchSetRegexMatchTuple")]
    public interface IWafregionalRegexMatchSetRegexMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalRegexMatchSetRegexMatchTupleFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
        string RegexPatternSetId
        {
            get;
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.WafregionalRegexMatchSetRegexMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalRegexMatchSetRegexMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalRegexMatchSetRegexMatchTupleFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafregionalRegexMatchSetRegexMatchTupleFieldToMatch[]>()!;
            }

            [JsiiProperty(name: "regexPatternSetId", typeJson: "{\"primitive\":\"string\"}")]
            public string RegexPatternSetId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
