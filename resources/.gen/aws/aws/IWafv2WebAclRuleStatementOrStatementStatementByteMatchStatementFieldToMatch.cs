using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatch), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatch")]
    public interface IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>body block.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody[]? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>method block.</summary>
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod[]? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader[]? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_query_argument block.</summary>
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_path block.</summary>
        [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath[]? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatch), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchAllQueryArguments[]?>();
            }

            /// <summary>body block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody[]? Body
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchBody[]?>();
            }

            /// <summary>method block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod[]? Method
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchMethod[]?>();
            }

            /// <summary>query_string block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchQueryString[]?>();
            }

            /// <summary>single_header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader[]? SingleHeader
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleHeader[]?>();
            }

            /// <summary>single_query_argument block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument[]?>();
            }

            /// <summary>uri_path block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath[]? UriPath
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatementFieldToMatchUriPath[]?>();
            }
        }
    }
}
