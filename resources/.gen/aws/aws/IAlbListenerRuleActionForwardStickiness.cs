using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleActionForwardStickiness), fullyQualifiedName: "aws.AlbListenerRuleActionForwardStickiness")]
    public interface IAlbListenerRuleActionForwardStickiness
    {
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        double Duration
        {
            get;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleActionForwardStickiness), fullyQualifiedName: "aws.AlbListenerRuleActionForwardStickiness")]
        internal sealed class _Proxy : DeputyBase, aws.IAlbListenerRuleActionForwardStickiness
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
            public double Duration
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
