using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.WafRegexMatchSetRegexMatchTuple")]
    public interface IWafRegexMatchSetRegexMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafRegexMatchSetRegexMatchTupleFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafRegexMatchSetRegexMatchTupleFieldToMatch[] FieldToMatch
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

        [JsiiTypeProxy(nativeType: typeof(IWafRegexMatchSetRegexMatchTuple), fullyQualifiedName: "aws.WafRegexMatchSetRegexMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.IWafRegexMatchSetRegexMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafRegexMatchSetRegexMatchTupleFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafRegexMatchSetRegexMatchTupleFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafRegexMatchSetRegexMatchTupleFieldToMatch[]>()!;
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
