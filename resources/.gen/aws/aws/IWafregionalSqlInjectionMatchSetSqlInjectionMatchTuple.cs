using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple), fullyQualifiedName: "aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTuple")]
    public interface IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple), fullyQualifiedName: "aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTuple")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTuple
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch[]>()!;
            }

            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
