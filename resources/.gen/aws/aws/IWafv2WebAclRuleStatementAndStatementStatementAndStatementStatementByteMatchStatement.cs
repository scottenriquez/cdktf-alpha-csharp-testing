using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement
    {
        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
        string PositionalConstraint
        {
            get;
        }

        [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}")]
        string SearchString
        {
            get;
        }

        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatch[]? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
            public string PositionalConstraint
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}")]
            public string SearchString
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>text_transformation block.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatch[]? FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementByteMatchStatementFieldToMatch[]?>();
            }
        }
    }
}
