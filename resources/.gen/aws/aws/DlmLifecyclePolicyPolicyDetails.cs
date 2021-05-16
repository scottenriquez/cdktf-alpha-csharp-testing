using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DlmLifecyclePolicyPolicyDetails")]
    public class DlmLifecyclePolicyPolicyDetails : aws.IDlmLifecyclePolicyPolicyDetails
    {
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] ResourceTypes
        {
            get;
            set;
        }

        /// <summary>schedule block.</summary>
        [JsiiProperty(name: "schedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IDlmLifecyclePolicyPolicyDetailsSchedule[] Schedule
        {
            get;
            set;
        }

        [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string> TargetTags
        {
            get;
            set;
        }
    }
}
