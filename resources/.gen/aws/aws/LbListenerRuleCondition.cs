using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LbListenerRuleCondition")]
    public class LbListenerRuleCondition : aws.ILbListenerRuleCondition
    {
        [JsiiOptional]
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Field
        {
            get;
            set;
        }

        /// <summary>host_header block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleConditionHostHeader[]? HostHeader
        {
            get;
            set;
        }

        /// <summary>http_header block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleConditionHttpHeader[]? HttpHeader
        {
            get;
            set;
        }

        /// <summary>http_request_method block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleConditionHttpRequestMethod[]? HttpRequestMethod
        {
            get;
            set;
        }

        /// <summary>path_pattern block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pathPattern", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleConditionPathPattern[]? PathPattern
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleConditionQueryString[]? QueryString
        {
            get;
            set;
        }

        /// <summary>source_ip block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIp", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleConditionSourceIp[]? SourceIp
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
