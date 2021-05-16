using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAlbListenerDefaultActionForward), fullyQualifiedName: "aws.AlbListenerDefaultActionForward")]
    public interface IAlbListenerDefaultActionForward
    {
        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
        aws.IAlbListenerDefaultActionForwardTargetGroup[] TargetGroup
        {
            get;
        }

        /// <summary>stickiness block.</summary>
        [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAlbListenerDefaultActionForwardStickiness[]? Stickiness
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerDefaultActionForward), fullyQualifiedName: "aws.AlbListenerDefaultActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.IAlbListenerDefaultActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_group block.</summary>
            [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
            public aws.IAlbListenerDefaultActionForwardTargetGroup[] TargetGroup
            {
                get => GetInstanceProperty<aws.IAlbListenerDefaultActionForwardTargetGroup[]>()!;
            }

            /// <summary>stickiness block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAlbListenerDefaultActionForwardStickiness[]? Stickiness
            {
                get => GetInstanceProperty<aws.IAlbListenerDefaultActionForwardStickiness[]?>();
            }
        }
    }
}
