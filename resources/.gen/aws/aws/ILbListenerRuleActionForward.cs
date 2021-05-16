using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleActionForward), fullyQualifiedName: "aws.LbListenerRuleActionForward")]
    public interface ILbListenerRuleActionForward
    {
        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
        aws.ILbListenerRuleActionForwardTargetGroup[] TargetGroup
        {
            get;
        }

        /// <summary>stickiness block.</summary>
        [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerRuleActionForwardStickiness[]? Stickiness
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleActionForward), fullyQualifiedName: "aws.LbListenerRuleActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerRuleActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_group block.</summary>
            [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
            public aws.ILbListenerRuleActionForwardTargetGroup[] TargetGroup
            {
                get => GetInstanceProperty<aws.ILbListenerRuleActionForwardTargetGroup[]>()!;
            }

            /// <summary>stickiness block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerRuleActionForwardStickiness[]? Stickiness
            {
                get => GetInstanceProperty<aws.ILbListenerRuleActionForwardStickiness[]?>();
            }
        }
    }
}
