using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatch")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatch : aws.IWafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments[]? AllQueryArguments
        {
            get;
            set;
        }

        /// <summary>body block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchBody\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchBody[]? Body
        {
            get;
            set;
        }

        /// <summary>method block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchMethod\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchMethod[]? Method
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchQueryString\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchQueryString[]? QueryString
        {
            get;
            set;
        }

        /// <summary>single_header block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleHeader[]? SingleHeader
        {
            get;
            set;
        }

        /// <summary>single_query_argument block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument[]? SingleQueryArgument
        {
            get;
            set;
        }

        /// <summary>uri_path block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriPath\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementSizeConstraintStatementFieldToMatchUriPath[]? UriPath
        {
            get;
            set;
        }
    }
}
