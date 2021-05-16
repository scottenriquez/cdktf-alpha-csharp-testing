using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatch")]
    public class Wafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatch : aws.IWafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
        {
            get;
            set;
        }

        /// <summary>body block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchBody[]? Body
        {
            get;
            set;
        }

        /// <summary>method block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchMethod[]? Method
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchQueryString[]? QueryString
        {
            get;
            set;
        }

        /// <summary>single_header block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader[]? SingleHeader
        {
            get;
            set;
        }

        /// <summary>single_query_argument block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
        {
            get;
            set;
        }

        /// <summary>uri_path block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchUriPath[]? UriPath
        {
            get;
            set;
        }
    }
}
