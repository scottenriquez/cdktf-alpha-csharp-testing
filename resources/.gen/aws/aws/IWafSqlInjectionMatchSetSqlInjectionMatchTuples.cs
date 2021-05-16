using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafSqlInjectionMatchSetSqlInjectionMatchTuples), fullyQualifiedName: "aws.WafSqlInjectionMatchSetSqlInjectionMatchTuples")]
    public interface IWafSqlInjectionMatchSetSqlInjectionMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafSqlInjectionMatchSetSqlInjectionMatchTuples), fullyQualifiedName: "aws.WafSqlInjectionMatchSetSqlInjectionMatchTuples")]
        internal sealed class _Proxy : DeputyBase, aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuples
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch[]>()!;
            }

            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
