using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalByteMatchSetByteMatchTuples), fullyQualifiedName: "aws.WafregionalByteMatchSetByteMatchTuples")]
    public interface IWafregionalByteMatchSetByteMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalByteMatchSetByteMatchTuplesFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafregionalByteMatchSetByteMatchTuplesFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
        string PositionalConstraint
        {
            get;
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiProperty(name: "targetString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalByteMatchSetByteMatchTuples), fullyQualifiedName: "aws.WafregionalByteMatchSetByteMatchTuples")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalByteMatchSetByteMatchTuples
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalByteMatchSetByteMatchTuplesFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafregionalByteMatchSetByteMatchTuplesFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafregionalByteMatchSetByteMatchTuplesFieldToMatch[]>()!;
            }

            [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
            public string PositionalConstraint
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "targetString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetString
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
