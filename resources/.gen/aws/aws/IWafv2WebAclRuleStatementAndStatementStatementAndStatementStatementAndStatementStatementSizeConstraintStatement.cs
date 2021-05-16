using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatement
    {
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ComparisonOperator
        {
            get;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch[]? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ComparisonOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>text_transformation block.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch[]? FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch[]?>();
            }
        }
    }
}
