using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatch")]
    public class Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatch : aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
        {
            get;
            set;
        }

        /// <summary>body block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchBody[]? Body
        {
            get;
            set;
        }

        /// <summary>method block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchMethod[]? Method
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchQueryString[]? QueryString
        {
            get;
            set;
        }

        /// <summary>single_header block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleHeader[]? SingleHeader
        {
            get;
            set;
        }

        /// <summary>single_query_argument block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
        {
            get;
            set;
        }

        /// <summary>uri_path block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementByteMatchStatementFieldToMatchUriPath[]? UriPath
        {
            get;
            set;
        }
    }
}
