using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerDefaultActionForward), fullyQualifiedName: "aws.LbListenerDefaultActionForward")]
    public interface ILbListenerDefaultActionForward
    {
        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
        aws.ILbListenerDefaultActionForwardTargetGroup[] TargetGroup
        {
            get;
        }

        /// <summary>stickiness block.</summary>
        [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILbListenerDefaultActionForwardStickiness[]? Stickiness
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerDefaultActionForward), fullyQualifiedName: "aws.LbListenerDefaultActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerDefaultActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_group block.</summary>
            [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
            public aws.ILbListenerDefaultActionForwardTargetGroup[] TargetGroup
            {
                get => GetInstanceProperty<aws.ILbListenerDefaultActionForwardTargetGroup[]>()!;
            }

            /// <summary>stickiness block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILbListenerDefaultActionForwardStickiness[]? Stickiness
            {
                get => GetInstanceProperty<aws.ILbListenerDefaultActionForwardStickiness[]?>();
            }
        }
    }
}
