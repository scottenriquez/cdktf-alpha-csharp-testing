using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetails), fullyQualifiedName: "aws.DlmLifecyclePolicyPolicyDetails")]
    public interface IDlmLifecyclePolicyPolicyDetails
    {
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ResourceTypes
        {
            get;
        }

        /// <summary>schedule block.</summary>
        [JsiiProperty(name: "schedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}")]
        aws.IDlmLifecyclePolicyPolicyDetailsSchedule[] Schedule
        {
            get;
        }

        [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> TargetTags
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetails), fullyQualifiedName: "aws.DlmLifecyclePolicyPolicyDetails")]
        internal sealed class _Proxy : DeputyBase, aws.IDlmLifecyclePolicyPolicyDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ResourceTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>schedule block.</summary>
            [JsiiProperty(name: "schedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}")]
            public aws.IDlmLifecyclePolicyPolicyDetailsSchedule[] Schedule
            {
                get => GetInstanceProperty<aws.IDlmLifecyclePolicyPolicyDetailsSchedule[]>()!;
            }

            [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> TargetTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }
        }
    }
}
