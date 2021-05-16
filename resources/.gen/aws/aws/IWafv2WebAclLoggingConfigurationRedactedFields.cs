using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.Wafv2WebAclLoggingConfigurationRedactedFields")]
    public interface IWafv2WebAclLoggingConfigurationRedactedFields
    {
        /// <summary>all_query_arguments block.</summary>
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments[]? AllQueryArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>body block.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsBody\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclLoggingConfigurationRedactedFieldsBody[]? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>method block.</summary>
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsMethod\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclLoggingConfigurationRedactedFieldsMethod[]? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclLoggingConfigurationRedactedFieldsQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_header block.</summary>
        [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader[]? SingleHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>single_query_argument block.</summary>
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument[]? SingleQueryArgument
        {
            get
            {
                return null;
            }
        }

        /// <summary>uri_path block.</summary>
        [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclLoggingConfigurationRedactedFieldsUriPath[]? UriPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.Wafv2WebAclLoggingConfigurationRedactedFields")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclLoggingConfigurationRedactedFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_query_arguments block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allQueryArguments", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments[]? AllQueryArguments
            {
                get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFieldsAllQueryArguments[]?>();
            }

            /// <summary>body block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsBody\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclLoggingConfigurationRedactedFieldsBody[]? Body
            {
                get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFieldsBody[]?>();
            }

            /// <summary>method block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsMethod\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclLoggingConfigurationRedactedFieldsMethod[]? Method
            {
                get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFieldsMethod[]?>();
            }

            /// <summary>query_string block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclLoggingConfigurationRedactedFieldsQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFieldsQueryString[]?>();
            }

            /// <summary>single_header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader[]? SingleHeader
            {
                get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleHeader[]?>();
            }

            /// <summary>single_query_argument block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument[]? SingleQueryArgument
            {
                get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument[]?>();
            }

            /// <summary>uri_path block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uriPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFieldsUriPath\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclLoggingConfigurationRedactedFieldsUriPath[]? UriPath
            {
                get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFieldsUriPath[]?>();
            }
        }
    }
}
