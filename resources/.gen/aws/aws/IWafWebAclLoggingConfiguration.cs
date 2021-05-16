using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafWebAclLoggingConfiguration), fullyQualifiedName: "aws.WafWebAclLoggingConfiguration")]
    public interface IWafWebAclLoggingConfiguration
    {
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        string LogDestination
        {
            get;
        }

        /// <summary>redacted_fields block.</summary>
        [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafWebAclLoggingConfigurationRedactedFields[]? RedactedFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAclLoggingConfiguration), fullyQualifiedName: "aws.WafWebAclLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IWafWebAclLoggingConfiguration
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
            [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafWebAclLoggingConfigurationRedactedFields[]? RedactedFields
            {
                get => GetInstanceProperty<aws.IWafWebAclLoggingConfigurationRedactedFields[]?>();
            }
        }
    }
}
