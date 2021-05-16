using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ConfigConfigRuleSource")]
    public class ConfigConfigRuleSource : aws.IConfigConfigRuleSource
    {
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Owner
        {
            get;
            set;
        }

        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SourceIdentifier
        {
            get;
            set;
        }

        /// <summary>source_detail block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDetail", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IConfigConfigRuleSourceSourceDetail[]? SourceDetail
        {
            get;
            set;
        }
    }
}
