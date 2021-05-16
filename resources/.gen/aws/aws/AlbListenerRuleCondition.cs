using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AlbListenerRuleCondition")]
    public class AlbListenerRuleCondition : aws.IAlbListenerRuleCondition
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
        [JsiiProperty(name: "hostHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleConditionHostHeader[]? HostHeader
        {
            get;
            set;
        }

        /// <summary>http_header block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleConditionHttpHeader[]? HttpHeader
        {
            get;
            set;
        }

        /// <summary>http_request_method block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleConditionHttpRequestMethod[]? HttpRequestMethod
        {
            get;
            set;
        }

        /// <summary>path_pattern block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pathPattern", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleConditionPathPattern[]? PathPattern
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleConditionQueryString[]? QueryString
        {
            get;
            set;
        }

        /// <summary>source_ip block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIp", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleConditionSourceIp[]? SourceIp
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
