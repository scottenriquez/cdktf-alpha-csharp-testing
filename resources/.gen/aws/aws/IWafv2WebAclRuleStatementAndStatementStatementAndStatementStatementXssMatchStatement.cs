using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementFieldToMatch[]? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>text_transformation block.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementFieldToMatch[]? FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementXssMatchStatementFieldToMatch[]?>();
            }
        }
    }
}
