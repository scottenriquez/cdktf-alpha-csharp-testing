using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DlmLifecyclePolicyPolicyDetailsSchedule")]
    public class DlmLifecyclePolicyPolicyDetailsSchedule : aws.IDlmLifecyclePolicyPolicyDetailsSchedule
    {
        /// <summary>create_rule block.</summary>
        [JsiiProperty(name: "createRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule[] CreateRule
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>retain_rule block.</summary>
        [JsiiProperty(name: "retainRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule[] RetainRule
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyTags", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? CopyTags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsToAdd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsToAdd
        {
            get;
            set;
        }
    }
}
