using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement")]
    public interface IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement
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
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch[]? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatement
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
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch[]? FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch[]?>();
            }
        }
    }
}
