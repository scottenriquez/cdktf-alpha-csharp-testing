using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatement : aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatement
    {
        /// <summary>byte_match_statement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementByteMatchStatement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementByteMatchStatement[]? ByteMatchStatement
        {
            get;
            set;
        }

        /// <summary>geo_match_statement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementGeoMatchStatement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementGeoMatchStatement[]? GeoMatchStatement
        {
            get;
            set;
        }

        /// <summary>ip_set_reference_statement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementIpSetReferenceStatement[]? IpSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement[]? RegexPatternSetReferenceStatement
        {
            get;
            set;
        }

        /// <summary>size_constraint_statement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementSizeConstraintStatement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementSizeConstraintStatement[]? SizeConstraintStatement
        {
            get;
            set;
        }

        /// <summary>sqli_match_statement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementSqliMatchStatement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementSqliMatchStatement[]? SqliMatchStatement
        {
            get;
            set;
        }

        /// <summary>xss_match_statement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementXssMatchStatement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementStatementAndStatementStatementXssMatchStatement[]? XssMatchStatement
        {
            get;
            set;
        }
    }
}
