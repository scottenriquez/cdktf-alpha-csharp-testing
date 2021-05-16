using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.WafregionalWebAclLoggingConfigurationRedactedFields")]
    public interface IWafregionalWebAclLoggingConfigurationRedactedFields
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.WafregionalWebAclLoggingConfigurationRedactedFields")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalWebAclLoggingConfigurationRedactedFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch[]>()!;
            }
        }
    }
}
