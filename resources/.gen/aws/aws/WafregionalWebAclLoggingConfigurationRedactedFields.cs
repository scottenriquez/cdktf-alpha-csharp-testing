using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafregionalWebAclLoggingConfigurationRedactedFields")]
    public class WafregionalWebAclLoggingConfigurationRedactedFields : aws.IWafregionalWebAclLoggingConfigurationRedactedFields
    {
        /// <summary>field_to_match block.</summary>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] FieldToMatch
        {
            get;
            set;
        }
    }
}
