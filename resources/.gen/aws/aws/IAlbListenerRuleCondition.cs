using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleCondition), fullyQualifiedName: "aws.AlbListenerRuleCondition")]
    public interface IAlbListenerRuleCondition
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
        [JsiiProperty(name: "hostHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleConditionHostHeader[]? HostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_header block.</summary>
        [JsiiProperty(name: "httpHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleConditionHttpHeader[]? HttpHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_request_method block.</summary>
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleConditionHttpRequestMethod[]? HttpRequestMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_pattern block.</summary>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleConditionPathPattern[]? PathPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleConditionQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_ip block.</summary>
        [JsiiProperty(name: "sourceIp", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleConditionSourceIp[]? SourceIp
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

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleCondition), fullyQualifiedName: "aws.AlbListenerRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.IAlbListenerRuleCondition
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
            [JsiiProperty(name: "hostHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionHostHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleConditionHostHeader[]? HostHeader
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleConditionHostHeader[]?>();
            }

            /// <summary>http_header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionHttpHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleConditionHttpHeader[]? HttpHeader
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleConditionHttpHeader[]?>();
            }

            /// <summary>http_request_method block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionHttpRequestMethod\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleConditionHttpRequestMethod[]? HttpRequestMethod
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleConditionHttpRequestMethod[]?>();
            }

            /// <summary>path_pattern block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pathPattern", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionPathPattern\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleConditionPathPattern[]? PathPattern
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleConditionPathPattern[]?>();
            }

            /// <summary>query_string block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleConditionQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleConditionQueryString[]?>();
            }

            /// <summary>source_ip block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIp", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleConditionSourceIp\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleConditionSourceIp[]? SourceIp
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleConditionSourceIp[]?>();
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
