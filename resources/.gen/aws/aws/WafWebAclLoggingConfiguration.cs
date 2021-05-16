using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafWebAclLoggingConfiguration")]
    public class WafWebAclLoggingConfiguration : aws.IWafWebAclLoggingConfiguration
    {
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LogDestination
        {
            get;
            set;
        }

        /// <summary>redacted_fields block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafWebAclLoggingConfigurationRedactedFields[]? RedactedFields
        {
            get;
            set;
        }
    }
}
