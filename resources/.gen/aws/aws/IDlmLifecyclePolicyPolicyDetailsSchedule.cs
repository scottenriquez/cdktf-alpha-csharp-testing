using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsSchedule), fullyQualifiedName: "aws.DlmLifecyclePolicyPolicyDetailsSchedule")]
    public interface IDlmLifecyclePolicyPolicyDetailsSchedule
    {
        /// <summary>create_rule block.</summary>
        [JsiiProperty(name: "createRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule\"},\"kind\":\"array\"}}")]
        aws.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule[] CreateRule
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>retain_rule block.</summary>
        [JsiiProperty(name: "retainRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule\"},\"kind\":\"array\"}}")]
        aws.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule[] RetainRule
        {
            get;
        }

        [JsiiProperty(name: "copyTags", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? CopyTags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tagsToAdd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsToAdd
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsSchedule), fullyQualifiedName: "aws.DlmLifecyclePolicyPolicyDetailsSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.IDlmLifecyclePolicyPolicyDetailsSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>create_rule block.</summary>
            [JsiiProperty(name: "createRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule\"},\"kind\":\"array\"}}")]
            public aws.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule[] CreateRule
            {
                get => GetInstanceProperty<aws.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>retain_rule block.</summary>
            [JsiiProperty(name: "retainRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule\"},\"kind\":\"array\"}}")]
            public aws.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule[] RetainRule
            {
                get => GetInstanceProperty<aws.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "copyTags", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? CopyTags
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tagsToAdd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsToAdd
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
