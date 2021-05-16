using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalXssMatchSetXssMatchTuple), fullyQualifiedName: "aws.WafregionalXssMatchSetXssMatchTuple")]
    public interface IWafregionalXssMatchSetXssMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalXssMatchSetXssMatchTupleFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafregionalXssMatchSetXssMatchTupleFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalXssMatchSetXssMatchTuple), fullyQualifiedName: "aws.WafregionalXssMatchSetXssMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalXssMatchSetXssMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalXssMatchSetXssMatchTupleFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafregionalXssMatchSetXssMatchTupleFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafregionalXssMatchSetXssMatchTupleFieldToMatch[]>()!;
            }

            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
