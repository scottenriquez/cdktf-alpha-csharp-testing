using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleCondition), fullyQualifiedName: "aws.LbListenerRuleCondition")]
    public interface ILbListenerRuleCondition
    {
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Field
        {
            get
            {
                return null;
            }
        }

        /// <summary>host_header block.</summary>
        [JsiiProperty(name: "hostHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleConditionHostHeader[]? HostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_header block.</summary>
        [JsiiProperty(name: "httpHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleConditionHttpHeader[]? HttpHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_request_method block.</summary>
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleConditionHttpRequestMethod[]? HttpRequestMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_pattern block.</summary>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleConditionPathPattern[]? PathPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleConditionQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_ip block.</summary>
        [JsiiProperty(name: "sourceIp", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleConditionSourceIp[]? SourceIp
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Values
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleCondition), fullyQualifiedName: "aws.LbListenerRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Field
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>host_header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleConditionHostHeader[]? HostHeader
            {
                get => GetInstanceProperty<aws.ILbListenerRuleConditionHostHeader[]?>();
            }

            /// <summary>http_header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleConditionHttpHeader[]? HttpHeader
            {
                get => GetInstanceProperty<aws.ILbListenerRuleConditionHttpHeader[]?>();
            }

            /// <summary>http_request_method block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleConditionHttpRequestMethod[]? HttpRequestMethod
            {
                get => GetInstanceProperty<aws.ILbListenerRuleConditionHttpRequestMethod[]?>();
            }

            /// <summary>path_pattern block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pathPattern", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleConditionPathPattern[]? PathPattern
            {
                get => GetInstanceProperty<aws.ILbListenerRuleConditionPathPattern[]?>();
            }

            /// <summary>query_string block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleConditionQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.ILbListenerRuleConditionQueryString[]?>();
            }

            /// <summary>source_ip block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIp", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleConditionSourceIp[]? SourceIp
            {
                get => GetInstanceProperty<aws.ILbListenerRuleConditionSourceIp[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Values
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
