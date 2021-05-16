using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclLoggingConfiguration), fullyQualifiedName: "aws.WafregionalWebAclLoggingConfiguration")]
    public interface IWafregionalWebAclLoggingConfiguration
    {
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        string LogDestination
        {
            get;
        }

        /// <summary>redacted_fields block.</summary>
        [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafregionalWebAclLoggingConfigurationRedactedFields[]? RedactedFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclLoggingConfiguration), fullyQualifiedName: "aws.WafregionalWebAclLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalWebAclLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
            public string LogDestination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>redacted_fields block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafregionalWebAclLoggingConfigurationRedactedFields[]? RedactedFields
            {
                get => GetInstanceProperty<aws.IWafregionalWebAclLoggingConfigurationRedactedFields[]?>();
            }
        }
    }
}
