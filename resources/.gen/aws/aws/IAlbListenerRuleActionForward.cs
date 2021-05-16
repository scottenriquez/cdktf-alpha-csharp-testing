using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleActionForward), fullyQualifiedName: "aws.AlbListenerRuleActionForward")]
    public interface IAlbListenerRuleActionForward
    {
        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
        aws.IAlbListenerRuleActionForwardTargetGroup[] TargetGroup
        {
            get;
        }

        /// <summary>stickiness block.</summary>
        [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerRuleActionForwardStickiness[]? Stickiness
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleActionForward), fullyQualifiedName: "aws.AlbListenerRuleActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.IAlbListenerRuleActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_group block.</summary>
            [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
            public aws.IAlbListenerRuleActionForwardTargetGroup[] TargetGroup
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleActionForwardTargetGroup[]>()!;
            }

            /// <summary>stickiness block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerRuleActionForwardStickiness[]? Stickiness
            {
                get => GetInstanceProperty<aws.IAlbListenerRuleActionForwardStickiness[]?>();
            }
        }
    }
}
