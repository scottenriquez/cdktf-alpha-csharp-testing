using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRegexPatternSetReferenceStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatement")]
    public interface IWafv2WebAclRuleStatementRegexPatternSetReferenceStatement
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch[]? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRegexPatternSetReferenceStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>text_transformation block.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch[]? FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch[]?>();
            }
        }
    }
}
