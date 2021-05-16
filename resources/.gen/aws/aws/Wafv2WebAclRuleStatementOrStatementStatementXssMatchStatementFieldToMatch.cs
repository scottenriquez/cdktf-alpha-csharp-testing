using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatch")]
    public class Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatch : aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
        {
            get;
            set;
        }

        /// <summary>body block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchBody[]? Body
        {
            get;
            set;
        }

        /// <summary>method block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchMethod[]? Method
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchQueryString[]? QueryString
        {
            get;
            set;
        }

        /// <summary>single_header block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchSingleHeader[]? SingleHeader
        {
            get;
            set;
        }

        /// <summary>single_query_argument block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
        {
            get;
            set;
        }

        /// <summary>uri_path block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatementFieldToMatchUriPath[]? UriPath
        {
            get;
            set;
        }
    }
}
