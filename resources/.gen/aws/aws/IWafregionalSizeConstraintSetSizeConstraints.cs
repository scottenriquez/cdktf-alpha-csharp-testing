using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalSizeConstraintSetSizeConstraints), fullyQualifiedName: "aws.WafregionalSizeConstraintSetSizeConstraints")]
    public interface IWafregionalSizeConstraintSetSizeConstraints
    {
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ComparisonOperator
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalSizeConstraintSetSizeConstraintsFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalSizeConstraintSetSizeConstraints), fullyQualifiedName: "aws.WafregionalSizeConstraintSetSizeConstraints")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalSizeConstraintSetSizeConstraints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ComparisonOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalSizeConstraintSetSizeConstraintsFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch[]>()!;
            }

            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
