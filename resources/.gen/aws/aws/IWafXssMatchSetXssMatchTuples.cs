using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafXssMatchSetXssMatchTuples), fullyQualifiedName: "aws.WafXssMatchSetXssMatchTuples")]
    public interface IWafXssMatchSetXssMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafXssMatchSetXssMatchTuplesFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafXssMatchSetXssMatchTuplesFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafXssMatchSetXssMatchTuples), fullyQualifiedName: "aws.WafXssMatchSetXssMatchTuples")]
        internal sealed class _Proxy : DeputyBase, aws.IWafXssMatchSetXssMatchTuples
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafXssMatchSetXssMatchTuplesFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafXssMatchSetXssMatchTuplesFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafXssMatchSetXssMatchTuplesFieldToMatch[]>()!;
            }

            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
