using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclLoggingConfigurationConfig), fullyQualifiedName: "aws.Wafv2WebAclLoggingConfigurationConfig")]
    public interface IWafv2WebAclLoggingConfigurationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>AWS Kinesis Firehose Delivery Stream ARNs.</summary>
        [JsiiProperty(name: "logDestinationConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] LogDestinationConfigs
        {
            get;
        }

        /// <summary>AWS WebACL ARN.</summary>
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceArn
        {
            get;
        }

        /// <summary>redacted_fields block.</summary>
        [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclLoggingConfigurationRedactedFields[]? RedactedFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclLoggingConfigurationConfig), fullyQualifiedName: "aws.Wafv2WebAclLoggingConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclLoggingConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>AWS Kinesis Firehose Delivery Stream ARNs.</summary>
            [JsiiProperty(name: "logDestinationConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] LogDestinationConfigs
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>AWS WebACL ARN.</summary>
            [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>redacted_fields block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclLoggingConfigurationRedactedFields[]? RedactedFields
            {
                get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFields[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
