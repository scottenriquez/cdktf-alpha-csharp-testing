using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupTag), fullyQualifiedName: "aws.AutoscalingGroupTag")]
    public interface IAutoscalingGroupTag
    {
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiProperty(name: "propagateAtLaunch", typeJson: "{\"primitive\":\"boolean\"}")]
        bool PropagateAtLaunch
        {
            get;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupTag), fullyQualifiedName: "aws.AutoscalingGroupTag")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingGroupTag
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "propagateAtLaunch", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool PropagateAtLaunch
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
