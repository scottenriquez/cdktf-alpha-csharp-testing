using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.WafWebAclLoggingConfigurationRedactedFields")]
    public interface IWafWebAclLoggingConfigurationRedactedFields
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.WafWebAclLoggingConfigurationRedactedFields")]
        internal sealed class _Proxy : DeputyBase, aws.IWafWebAclLoggingConfigurationRedactedFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[]>()!;
            }
        }
    }
}
