using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch")]
    public interface IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>body block.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody[]? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>method block.</summary>
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod[]? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader[]? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_query_argument block.</summary>
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_path block.</summary>
        [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath[]? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments[]?>();
            }

            /// <summary>body block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody[]? Body
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody[]?>();
            }

            /// <summary>method block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod[]? Method
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod[]?>();
            }

            /// <summary>query_string block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString[]?>();
            }

            /// <summary>single_header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader[]? SingleHeader
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader[]?>();
            }

            /// <summary>single_query_argument block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument[]?>();
            }

            /// <summary>uri_path block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath[]? UriPath
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath[]?>();
            }
        }
    }
}
