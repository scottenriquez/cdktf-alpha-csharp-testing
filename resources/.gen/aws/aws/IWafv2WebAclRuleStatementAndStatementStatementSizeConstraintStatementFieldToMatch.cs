using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatch), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatch")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>body block.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody[]? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>method block.</summary>
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod[]? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader[]? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_query_argument block.</summary>
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_path block.</summary>
        [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath[]? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatch), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments[]?>();
            }

            /// <summary>body block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody[]? Body
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody[]?>();
            }

            /// <summary>method block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod[]? Method
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod[]?>();
            }

            /// <summary>query_string block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString[]?>();
            }

            /// <summary>single_header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader[]? SingleHeader
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader[]?>();
            }

            /// <summary>single_query_argument block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument[]?>();
            }

            /// <summary>uri_path block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath[]? UriPath
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath[]?>();
            }
        }
    }
}
