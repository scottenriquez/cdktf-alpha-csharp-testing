using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatch), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatch")]
    public interface IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>body block.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchBody[]? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>method block.</summary>
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchMethod[]? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleHeader[]? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_query_argument block.</summary>
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_path block.</summary>
        [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchUriPath[]? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatch), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchAllQueryArguments[]?>();
            }

            /// <summary>body block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchBody[]? Body
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchBody[]?>();
            }

            /// <summary>method block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchMethod[]? Method
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchMethod[]?>();
            }

            /// <summary>query_string block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchQueryString[]?>();
            }

            /// <summary>single_header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleHeader[]? SingleHeader
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleHeader[]?>();
            }

            /// <summary>single_query_argument block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchSingleQueryArgument[]?>();
            }

            /// <summary>uri_path block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchUriPath[]? UriPath
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementSqliMatchStatementFieldToMatchUriPath[]?>();
            }
        }
    }
}
